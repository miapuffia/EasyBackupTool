using Codeplex.Data;
using Microsoft.WindowsAPICodePack.Dialogs;
using Opulos.Core.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using TestRef;

namespace EasyBackupTool {
    public partial class MainForm : Form {
        private class BackupData {
            public string Name;
            public string BackupNameFormat;
            public string SourcePath;
            public string DestinationPath;

            public BackupData(string Name, string BackupNameFormat, string SourcePath, string DestinationPath) {
                this.Name = Name;
                this.BackupNameFormat = BackupNameFormat;
                this.SourcePath = SourcePath;
                this.DestinationPath = DestinationPath;
            }
        }

        string dataFilePath = Directory.GetCurrentDirectory() + "/data.txt";

        dynamic json = new DynamicJson();

        public MainForm() {
            InitializeComponent();

            if(File.Exists(dataFilePath)) {
                json = DynamicJson.Parse(File.ReadAllText(dataFilePath));
            }

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxHeaderCell col1Header = new DataGridViewCheckBoxHeaderCell();
            col1.HeaderCell = col1Header;
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.FillWeight = 10;

            col1Header.OnCheckBoxClicked += new CheckBoxClickedHandler(delegate (bool state) {
                foreach(DataGridViewRow dgvr in backupsDataGridView.Rows) {
                    dgvr.Cells[0].ReadOnly = true; //This is very hacky but it fixes a bug in updating the visual state
                    dgvr.Cells[0].Value = state;
                    dgvr.Cells[0].ReadOnly = false;
                }
            });

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewColumnHeaderCell col2Header = new DataGridViewColumnHeaderCell();
            col2.HeaderCell = col2Header;
            col2.HeaderText = "Name";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.FillWeight = 50;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewColumnHeaderCell col3Header = new DataGridViewColumnHeaderCell();
            col3.HeaderCell = col3Header;
            col3.HeaderText = "Source path";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.FillWeight = 100;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            DataGridViewColumnHeaderCell col4Header = new DataGridViewColumnHeaderCell();
            col4.HeaderCell = col4Header;
            col4.HeaderText = "Destination path";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col4.FillWeight = 100;

            backupsDataGridView.Columns.Add(col1);
            backupsDataGridView.Columns.Add(col2);
            backupsDataGridView.Columns.Add(col3);
            backupsDataGridView.Columns.Add(col4);

            mainTabControl_SelectedIndexChanged(null, null);
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            switch(mainTabControl.SelectedIndex) {
                case 0:
                    addBackupMessageTableLayoutPanel.Visible = true;

                    totalBackupsTextProgressBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.NoText;
                    totalBackupsTextProgressBar.Value = 0;

                    if(!json.IsDefined("backups")) {
                        return;
                    }

                    backupsDataGridView.Rows.Clear();

                    foreach(dynamic backupItem in json.backups) {
                        backupsDataGridView.Rows.Add(false, backupItem.name, backupItem.sourcePath, backupItem.destinationPath);
                    }

                    if(backupsDataGridView.Rows.Count > 0) {
                        addBackupMessageTableLayoutPanel.Visible = false;
                    }

                    HandleMakeBackupsButtonState();

                    break;
                case 2:
                    if(!json.IsDefined("backups")) {
                        return;
                    }

                    editAccordion.Clear();

                    foreach(dynamic backupItem in json.backups) {
                        TableLayoutPanel tlp = new TableLayoutPanel { TabStop = true, Dock = DockStyle.Fill };

                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 1));

                        tlp.Controls.Add(new Label { Text = "Name:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight, Font = new Font(FontFamily.GenericSansSerif, 10) }, 0, 0);
                        tlp.Controls.Add(new TextBox { Text = backupItem.name, Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif, 10) }, 1, 0);
                        tlp.Controls.Add(new CheckBox { Text = "Mark for deletion", AutoSize = true, Font = new Font(FontFamily.GenericSansSerif, 10) }, 3, 0);

                        TextBox sourcePathTextBox = new TextBox { Text = backupItem.sourcePath, Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif, 10), ReadOnly = true };
                        tlp.SetColumnSpan(sourcePathTextBox, 2);

                        Button pickSourcePathButton = new Button { Text = "...", AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
                        pickSourcePathButton.Click += new EventHandler(delegate (object sender2, EventArgs e2) {
                            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

                            dialog.IsFolderPicker = true;

                            if(dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                                sourcePathTextBox.Text = dialog.FileName;
                            }
                        });

                        tlp.Controls.Add(new Label { Text = "Source folder path:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight, Font = new Font(FontFamily.GenericSansSerif, 10) }, 0, 1);
                        tlp.Controls.Add(sourcePathTextBox, 1, 1);
                        tlp.Controls.Add(pickSourcePathButton, 3, 1);

                        TextBox destinationPathTextBox = new TextBox { Text = backupItem.destinationPath, Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif, 10), ReadOnly = true };
                        tlp.SetColumnSpan(destinationPathTextBox, 2);

                        Button pickDestinationPathButton = new Button { Text = "...", AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
                        pickDestinationPathButton.Click += new EventHandler(delegate (object sender2, EventArgs e2) {
                            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

                            dialog.IsFolderPicker = true;

                            if(dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                                destinationPathTextBox.Text = dialog.FileName;
                            }
                        });

                        tlp.Controls.Add(new Label { Text = "Destination folder path:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight, Font = new Font(FontFamily.GenericSansSerif, 10) }, 0, 2);
                        tlp.Controls.Add(destinationPathTextBox, 1, 2);
                        tlp.Controls.Add(pickDestinationPathButton, 3, 2);
                        tlp.Tag = backupItem.name;

                        CheckBox checkbox = editAccordion.Add(tlp, backupItem.name);

                        checkbox.Tag = backupItem.name;
                    }

                    break;

                case 3:
                    manageDataGridView.Rows.Clear();

                    if(!File.Exists(Directory.GetCurrentDirectory() + "/log.txt")) {
                        return;
                    }

                    dynamic logJson = DynamicJson.Parse(File.OpenRead(Directory.GetCurrentDirectory() + "/log.txt"));

                    if(!logJson.IsDefined("backupLogs")) {
                        return;
                    }

                    foreach(dynamic backupLogItem in logJson.backupLogs) {
                        manageDataGridView.Rows.Add(backupLogItem.name, backupLogItem.sourcePath, backupLogItem.destinationPath, backupLogItem.date, backupLogItem.result);
                    }

                    break;

                case 4:
                    if(!json.IsDefined("settings")) {
                        return;
                    }

                    backupNameFormatTextBox.Text = json.settings.backupNameFormat;

                    break;
            }
        }

        private async void makeBackupsButton_Click(object sender, EventArgs e) {
            totalBackupsTextProgressBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.NoText;
            totalBackupsTextProgressBar.Value = 0;

            string backupNameFormat = backupNameFormatTextBox.Text;

            if(json.IsDefined("settings")) {
                backupNameFormat = json.settings.backupNameFormat;
            }

            List<BackupData> backups = new List<BackupData>();

            foreach(DataGridViewRow dgvr in backupsDataGridView.Rows) {
                if(dgvr.Cells[0].ValueType == typeof(bool) && ((bool) dgvr.Cells[0].Value)) {
                    for(int i = 1; i < 10000; i++) {
                        //Replace name
                        string potentialFolderName = backupNameFormat.Replace("{name}", dgvr.Cells[1].Value.ToString());

                        if(i == 1) {
                            //Remove duplicate string portion
                            potentialFolderName = potentialFolderName.Substring(0, potentialFolderName.IndexOf('[')) + potentialFolderName.Substring(potentialFolderName.LastIndexOf(']') + 1);
                        } else {
                            //Replace duplicateNum and remove brackets
                            potentialFolderName = potentialFolderName.Replace("{duplicateNum}", i + "").Replace("[", "").Replace("]", "");
                        }

                        //Will this be a duplicate folder
                        if(Directory.Exists(dgvr.Cells[3].Value.ToString() + "/" + DateTime.Now.ToString(potentialFolderName))) {
                            continue;
                        }

                        backups.Add(new BackupData(dgvr.Cells[1].Value.ToString(), potentialFolderName, dgvr.Cells[2].Value.ToString(), dgvr.Cells[3].Value.ToString()));
                        break;
                    }
                }
            }

            if(backups.Count == 0) {
                return;
            }

            totalBackupsTextProgressBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CurrProgress;
            totalBackupsTextProgressBar.Maximum = backups.Count;

            bool cancelled = false;
            string result = "";

            foreach(BackupData bd in backups) {
                if(!cancelled) {
                    result = await CopyAsync(bd);

                    if(result == "OperationCanceledException") {
                        cancelled = true;
                    } else {
                        if(result != "Success") {
                            totalBackupsTextProgressBar.ProgressColor = Color.PaleVioletRed;
                        }

                        totalBackupsTextProgressBar.Value++;
                    }
                }

                LogBackup(bd, result);
            }
        }

        private async Task<string> CopyAsync(BackupData bd) {
            return await Task.Run<string>(() => {
                try {
                    FileSystem.CopyDirectory(bd.SourcePath, bd.DestinationPath + "/" + DateTime.Now.ToString(bd.BackupNameFormat), UIOption.AllDialogs, UICancelOption.ThrowException);
                } catch(Exception e) {
                    return e.GetType().Name;
                }

                return "Success";
            });
        }

        private void LogBackup(BackupData bd, string resultString) {
            dynamic logJson = new DynamicJson();

            if(File.Exists(Directory.GetCurrentDirectory() + "/log.txt")) {
                logJson = DynamicJson.Parse(File.OpenRead(Directory.GetCurrentDirectory() + "/log.txt"));
            }

            if(!logJson.IsDefined("backupLogs")) {
                logJson.backupLogs = new String[] { };
            }

            logJson.backupLogs[((Object[]) logJson.backupLogs).Length] = new { name = bd.Name, sourcePath = bd.SourcePath, destinationPath = bd.DestinationPath + "/" + DateTime.Now.ToString(bd.BackupNameFormat), result = resultString, date = DateTime.Now.ToString()};

            File.WriteAllText(Directory.GetCurrentDirectory() + "/log.txt", logJson.ToString());
        }

        private void HandleMakeBackupsButtonState() {
            makeBackupsButton.Enabled = (GetBakupsCheckedState() == 2);
        }

        private int GetBakupsCheckedState() {
            int noneChecked = 1;
            int allChecked = 1;

            foreach(DataGridViewRow dgvr in backupsDataGridView.Rows) {
                if(dgvr.Cells[0].ValueType == typeof(bool)) {
                    if(((bool) dgvr.Cells[0].Value)) {
                        noneChecked = 0;
                    } else {
                        allChecked = 0;
                    }
                }
            }

            //0 if both are false
            //1 if none checked
            //2 if all checked
            //3 if error
            return noneChecked + (allChecked * 2);
        }

        private void addBackupButton_Click(object sender, EventArgs e) {
            if(!json.IsDefined("backups")) {
                json.backups = new String[] { };
            }

            json.backups[((Object[])json.backups).Length] = new { name = nameTextBox.Text, sourcePath = sourceTextBox.Text, destinationPath = destinationTextBox.Text };

            SaveJson();
        }

        private void HandleAddButtonBackupState() {
            addBackupButton.Enabled = !(nameTextBox.Text == "" || sourceTextBox.Text == "" || destinationTextBox.Text == "");
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            HandleAddButtonBackupState();
        }

        private void sourceTextBox_TextChanged(object sender, EventArgs e) {
            HandleAddButtonBackupState();
        }

        private void destinationTextBox_TextChanged(object sender, EventArgs e) {
            HandleAddButtonBackupState();
        }

        private void pickSourceButton_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                sourceTextBox.Text = dialog.FileName;
            }
        }

        private void pickDetsinationButton_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                destinationTextBox.Text = dialog.FileName;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e) {
            if(!json.IsDefined("settings")) {
                json.settings = new { };
            }

            json.settings.backupNameFormat = backupNameFormatTextBox.Text;

            SaveJson();
        }

        private void HandleSaveSettingsButtonState() {
            saveSettingsButton.Enabled = !(backupNameFormatTextBox.Text == "");
        }

        private void backupNameFormatTextBox_TextChanged(object sender, EventArgs e) {
            HandleSaveSettingsButtonState();
        }

        private void backupNameFormatLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings");
        }

        private void SaveJson() {
            File.WriteAllText(dataFilePath, json.ToString());
        }

        private void saveChangesButton_Click(object sender, EventArgs e) {
            json.Delete("backups");
            json.backups = new String[] { };

            for(int i = 0; i < editAccordion.Count; i++) {
                TableLayoutPanel tlp = (TableLayoutPanel) editAccordion.Content(i);

                if(((CheckBox) tlp.GetControlFromPosition(3, 0)).Checked) {
                    continue;
                }

                json.backups[i] = new { name = tlp.GetControlFromPosition(1, 0).Text, sourcePath = tlp.GetControlFromPosition(1, 1).Text, destinationPath = tlp.GetControlFromPosition(1, 2).Text };
            }

            SaveJson();

            mainTabControl_SelectedIndexChanged(null, null);
        }

        private void backupsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            HandleMakeBackupsButtonState();
        }

        private void backupsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if(backupsDataGridView.IsCurrentCellDirty) {
                backupsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void addBackupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            mainTabControl.SelectedIndex = 1;
        }

        private void emailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("mailto:miaweb.rr@gmail.com");
        }
    }
}
