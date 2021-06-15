
namespace EasyBackupTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.backupTabPage = new System.Windows.Forms.TabPage();
            this.backupTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.backupsDataGridView = new System.Windows.Forms.DataGridView();
            this.makeBackupsButton = new System.Windows.Forms.Button();
            this.totalBackupsTextProgressBar = new ProgressBarSample.TextProgressBar();
            this.addBackupMessageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addBackupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.addTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.pickSourceButton = new System.Windows.Forms.Button();
            this.pickDetsinationButton = new System.Windows.Forms.Button();
            this.addBackupButton = new System.Windows.Forms.Button();
            this.nameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.editTabPage = new System.Windows.Forms.TabPage();
            this.editTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editAccordion = new Opulos.Core.UI.Accordion();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.manageTabPage = new System.Windows.Forms.TabPage();
            this.manageDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DestinationColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.settingsParentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.backupNameFormatLabel = new System.Windows.Forms.Label();
            this.backupNameFormatTextBox = new System.Windows.Forms.TextBox();
            this.backupNameFormatLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.backupNameExtraLabel = new System.Windows.Forms.Label();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.aboutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AboutInnerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.backupTabPage.SuspendLayout();
            this.backupTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupsDataGridView)).BeginInit();
            this.addBackupMessageTableLayoutPanel.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.addTableLayoutPanel.SuspendLayout();
            this.nameTableLayoutPanel.SuspendLayout();
            this.editTabPage.SuspendLayout();
            this.editTableLayoutPanel.SuspendLayout();
            this.manageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.settingsParentTableLayoutPanel.SuspendLayout();
            this.settingsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.aboutTableLayoutPanel.SuspendLayout();
            this.AboutInnerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.backupTabPage);
            this.mainTabControl.Controls.Add(this.addTabPage);
            this.mainTabControl.Controls.Add(this.editTabPage);
            this.mainTabControl.Controls.Add(this.manageTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1121, 490);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // backupTabPage
            // 
            this.backupTabPage.Controls.Add(this.backupTableLayoutPanel);
            this.backupTabPage.Location = new System.Drawing.Point(4, 22);
            this.backupTabPage.Name = "backupTabPage";
            this.backupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.backupTabPage.Size = new System.Drawing.Size(1113, 464);
            this.backupTabPage.TabIndex = 0;
            this.backupTabPage.Text = "Make backups";
            this.backupTabPage.UseVisualStyleBackColor = true;
            // 
            // backupTableLayoutPanel
            // 
            this.backupTableLayoutPanel.ColumnCount = 1;
            this.backupTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backupTableLayoutPanel.Controls.Add(this.backupsDataGridView, 0, 0);
            this.backupTableLayoutPanel.Controls.Add(this.makeBackupsButton, 0, 2);
            this.backupTableLayoutPanel.Controls.Add(this.totalBackupsTextProgressBar, 0, 3);
            this.backupTableLayoutPanel.Controls.Add(this.addBackupMessageTableLayoutPanel, 0, 1);
            this.backupTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.backupTableLayoutPanel.Name = "backupTableLayoutPanel";
            this.backupTableLayoutPanel.RowCount = 4;
            this.backupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.backupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.backupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.backupTableLayoutPanel.Size = new System.Drawing.Size(1107, 458);
            this.backupTableLayoutPanel.TabIndex = 0;
            // 
            // backupsDataGridView
            // 
            this.backupsDataGridView.AllowUserToAddRows = false;
            this.backupsDataGridView.AllowUserToDeleteRows = false;
            this.backupsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.backupsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.backupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.backupsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.backupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.backupsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.backupsDataGridView.Name = "backupsDataGridView";
            this.backupsDataGridView.RowHeadersVisible = false;
            this.backupsDataGridView.RowHeadersWidth = 50;
            this.backupsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.backupsDataGridView.Size = new System.Drawing.Size(1101, 338);
            this.backupsDataGridView.TabIndex = 2;
            this.backupsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backupsDataGridView_CellContentClick);
            this.backupsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backupsDataGridView_CellDoubleClick);
            this.backupsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.backupsDataGridView_CellValueChanged);
            this.backupsDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.backupsDataGridView_CurrentCellDirtyStateChanged);
            // 
            // makeBackupsButton
            // 
            this.makeBackupsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.makeBackupsButton.AutoSize = true;
            this.makeBackupsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeBackupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.makeBackupsButton.Location = new System.Drawing.Point(454, 387);
            this.makeBackupsButton.Name = "makeBackupsButton";
            this.makeBackupsButton.Size = new System.Drawing.Size(199, 41);
            this.makeBackupsButton.TabIndex = 1;
            this.makeBackupsButton.Text = "Make backups";
            this.makeBackupsButton.UseVisualStyleBackColor = true;
            this.makeBackupsButton.Click += new System.EventHandler(this.makeBackupsButton_Click);
            // 
            // totalBackupsTextProgressBar
            // 
            this.totalBackupsTextProgressBar.CustomText = "";
            this.totalBackupsTextProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalBackupsTextProgressBar.Location = new System.Drawing.Point(3, 434);
            this.totalBackupsTextProgressBar.Name = "totalBackupsTextProgressBar";
            this.totalBackupsTextProgressBar.ProgressColor = System.Drawing.Color.LightGreen;
            this.totalBackupsTextProgressBar.Size = new System.Drawing.Size(1101, 21);
            this.totalBackupsTextProgressBar.TabIndex = 3;
            this.totalBackupsTextProgressBar.TextColor = System.Drawing.Color.Black;
            this.totalBackupsTextProgressBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalBackupsTextProgressBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.NoText;
            // 
            // addBackupMessageTableLayoutPanel
            // 
            this.addBackupMessageTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addBackupMessageTableLayoutPanel.AutoSize = true;
            this.addBackupMessageTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBackupMessageTableLayoutPanel.ColumnCount = 3;
            this.addBackupMessageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addBackupMessageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addBackupMessageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addBackupMessageTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.addBackupMessageTableLayoutPanel.Controls.Add(this.addBackupLinkLabel, 1, 0);
            this.addBackupMessageTableLayoutPanel.Controls.Add(this.label2, 2, 0);
            this.addBackupMessageTableLayoutPanel.Location = new System.Drawing.Point(282, 354);
            this.addBackupMessageTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.addBackupMessageTableLayoutPanel.Name = "addBackupMessageTableLayoutPanel";
            this.addBackupMessageTableLayoutPanel.RowCount = 1;
            this.addBackupMessageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addBackupMessageTableLayoutPanel.Size = new System.Drawing.Size(542, 30);
            this.addBackupMessageTableLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have no backups added. Go to the";
            // 
            // addBackupLinkLabel
            // 
            this.addBackupLinkLabel.AutoSize = true;
            this.addBackupLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addBackupLinkLabel.Location = new System.Drawing.Point(286, 0);
            this.addBackupLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.addBackupLinkLabel.Name = "addBackupLinkLabel";
            this.addBackupLinkLabel.Size = new System.Drawing.Size(107, 20);
            this.addBackupLinkLabel.TabIndex = 2;
            this.addBackupLinkLabel.TabStop = true;
            this.addBackupLinkLabel.Text = "Add a backup";
            this.addBackupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addBackupLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(393, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "tab to add backups.";
            // 
            // addTabPage
            // 
            this.addTabPage.Controls.Add(this.addTableLayoutPanel);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(1113, 464);
            this.addTabPage.TabIndex = 1;
            this.addTabPage.Text = "Add a backup";
            this.addTabPage.UseVisualStyleBackColor = true;
            // 
            // addTableLayoutPanel
            // 
            this.addTableLayoutPanel.ColumnCount = 3;
            this.addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.addTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.addTableLayoutPanel.Controls.Add(this.sourceLabel, 0, 1);
            this.addTableLayoutPanel.Controls.Add(this.destinationLabel, 0, 2);
            this.addTableLayoutPanel.Controls.Add(this.sourceTextBox, 1, 1);
            this.addTableLayoutPanel.Controls.Add(this.destinationTextBox, 1, 2);
            this.addTableLayoutPanel.Controls.Add(this.pickSourceButton, 2, 1);
            this.addTableLayoutPanel.Controls.Add(this.pickDetsinationButton, 2, 2);
            this.addTableLayoutPanel.Controls.Add(this.addBackupButton, 0, 4);
            this.addTableLayoutPanel.Controls.Add(this.nameTableLayoutPanel, 1, 0);
            this.addTableLayoutPanel.Controls.Add(this.messageLabel, 0, 3);
            this.addTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.addTableLayoutPanel.Name = "addTableLayoutPanel";
            this.addTableLayoutPanel.RowCount = 5;
            this.addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addTableLayoutPanel.Size = new System.Drawing.Size(1107, 458);
            this.addTableLayoutPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(280, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // sourceLabel
            // 
            this.sourceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sourceLabel.Location = new System.Drawing.Point(200, 35);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(129, 17);
            this.sourceLabel.TabIndex = 1;
            this.sourceLabel.Text = "Source folder path:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.destinationLabel.Location = new System.Drawing.Point(174, 64);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(155, 17);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "Destination folder path:";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sourceTextBox.Location = new System.Drawing.Point(335, 32);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(658, 23);
            this.sourceTextBox.TabIndex = 5;
            this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.destinationTextBox.Location = new System.Drawing.Point(335, 61);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.ReadOnly = true;
            this.destinationTextBox.Size = new System.Drawing.Size(658, 23);
            this.destinationTextBox.TabIndex = 6;
            this.destinationTextBox.TextChanged += new System.EventHandler(this.destinationTextBox_TextChanged);
            // 
            // pickSourceButton
            // 
            this.pickSourceButton.AutoSize = true;
            this.pickSourceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pickSourceButton.Location = new System.Drawing.Point(999, 32);
            this.pickSourceButton.Name = "pickSourceButton";
            this.pickSourceButton.Size = new System.Drawing.Size(26, 23);
            this.pickSourceButton.TabIndex = 7;
            this.pickSourceButton.Text = "...";
            this.pickSourceButton.UseVisualStyleBackColor = true;
            this.pickSourceButton.Click += new System.EventHandler(this.pickSourceButton_Click);
            // 
            // pickDetsinationButton
            // 
            this.pickDetsinationButton.AutoSize = true;
            this.pickDetsinationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pickDetsinationButton.Location = new System.Drawing.Point(999, 61);
            this.pickDetsinationButton.Name = "pickDetsinationButton";
            this.pickDetsinationButton.Size = new System.Drawing.Size(26, 23);
            this.pickDetsinationButton.TabIndex = 8;
            this.pickDetsinationButton.Text = "...";
            this.pickDetsinationButton.UseVisualStyleBackColor = true;
            this.pickDetsinationButton.Click += new System.EventHandler(this.pickDetsinationButton_Click);
            // 
            // addBackupButton
            // 
            this.addBackupButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBackupButton.AutoSize = true;
            this.addBackupButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTableLayoutPanel.SetColumnSpan(this.addBackupButton, 3);
            this.addBackupButton.Enabled = false;
            this.addBackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addBackupButton.Location = new System.Drawing.Point(470, 414);
            this.addBackupButton.Name = "addBackupButton";
            this.addBackupButton.Size = new System.Drawing.Size(167, 41);
            this.addBackupButton.TabIndex = 3;
            this.addBackupButton.Text = "Add backup";
            this.addBackupButton.UseVisualStyleBackColor = true;
            this.addBackupButton.Click += new System.EventHandler(this.addBackupButton_Click);
            // 
            // nameTableLayoutPanel
            // 
            this.nameTableLayoutPanel.AutoSize = true;
            this.nameTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nameTableLayoutPanel.ColumnCount = 2;
            this.nameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayoutPanel.Controls.Add(this.nameTextBox, 0, 0);
            this.nameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTableLayoutPanel.Location = new System.Drawing.Point(332, 0);
            this.nameTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.nameTableLayoutPanel.Name = "nameTableLayoutPanel";
            this.nameTableLayoutPanel.RowCount = 1;
            this.nameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.nameTableLayoutPanel.Size = new System.Drawing.Size(664, 29);
            this.nameTableLayoutPanel.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(3, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(326, 23);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.addTableLayoutPanel.SetColumnSpan(this.messageLabel, 3);
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageLabel.Location = new System.Drawing.Point(3, 97);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(1101, 17);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "The source folder will be backed up to the destination folder.";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editTabPage
            // 
            this.editTabPage.Controls.Add(this.editTableLayoutPanel);
            this.editTabPage.Location = new System.Drawing.Point(4, 22);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editTabPage.Size = new System.Drawing.Size(1113, 464);
            this.editTabPage.TabIndex = 2;
            this.editTabPage.Text = "Edit backups";
            this.editTabPage.UseVisualStyleBackColor = true;
            // 
            // editTableLayoutPanel
            // 
            this.editTableLayoutPanel.ColumnCount = 1;
            this.editTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editTableLayoutPanel.Controls.Add(this.editAccordion, 0, 0);
            this.editTableLayoutPanel.Controls.Add(this.saveChangesButton, 0, 1);
            this.editTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.editTableLayoutPanel.Name = "editTableLayoutPanel";
            this.editTableLayoutPanel.RowCount = 2;
            this.editTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editTableLayoutPanel.Size = new System.Drawing.Size(1107, 458);
            this.editTableLayoutPanel.TabIndex = 0;
            // 
            // editAccordion
            // 
            this.editAccordion.AddResizeBars = true;
            this.editAccordion.AllowMouseResize = true;
            this.editAccordion.AnimateCloseEffect = Opulos.Core.UI.AnimateWindowFlags.None;
            this.editAccordion.AnimateCloseMillis = 300;
            this.editAccordion.AnimateOpenEffect = Opulos.Core.UI.AnimateWindowFlags.None;
            this.editAccordion.AnimateOpenMillis = 300;
            this.editAccordion.AutoFixDockStyle = false;
            this.editAccordion.AutoScroll = true;
            this.editAccordion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editAccordion.CheckBoxFactory = null;
            this.editAccordion.CheckBoxMargin = new System.Windows.Forms.Padding(2);
            this.editAccordion.ContentBackColor = null;
            this.editAccordion.ContentMargin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.editAccordion.ContentPadding = new System.Windows.Forms.Padding(1);
            this.editAccordion.ControlBackColor = null;
            this.editAccordion.ControlMinimumHeightIsItsPreferredHeight = true;
            this.editAccordion.ControlMinimumWidthIsItsPreferredWidth = true;
            this.editAccordion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editAccordion.DownArrow = null;
            this.editAccordion.FillHeight = true;
            this.editAccordion.FillLastOpened = false;
            this.editAccordion.FillModeGrowOnly = false;
            this.editAccordion.FillResetOnCollapse = false;
            this.editAccordion.FillWidth = true;
            this.editAccordion.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this.editAccordion.GrabRequiresPositiveFillWeight = true;
            this.editAccordion.GrabWidth = 6;
            this.editAccordion.GrowAndShrink = true;
            this.editAccordion.Insets = new System.Windows.Forms.Padding(5);
            this.editAccordion.Location = new System.Drawing.Point(3, 3);
            this.editAccordion.Name = "editAccordion";
            this.editAccordion.OpenOnAdd = false;
            this.editAccordion.OpenOneOnly = false;
            this.editAccordion.Padding = new System.Windows.Forms.Padding(5);
            this.editAccordion.ResizeBarFactory = null;
            this.editAccordion.ResizeBarsAlign = 0.5D;
            this.editAccordion.ResizeBarsArrowKeyDelta = 10;
            this.editAccordion.ResizeBarsFadeInMillis = 800;
            this.editAccordion.ResizeBarsFadeOutMillis = 800;
            this.editAccordion.ResizeBarsFadeProximity = 24;
            this.editAccordion.ResizeBarsFill = 1D;
            this.editAccordion.ResizeBarsKeepFocusAfterMouseDrag = false;
            this.editAccordion.ResizeBarsKeepFocusIfControlOutOfView = true;
            this.editAccordion.ResizeBarsKeepFocusOnClick = true;
            this.editAccordion.ResizeBarsMargin = null;
            this.editAccordion.ResizeBarsMinimumLength = 50;
            this.editAccordion.ResizeBarsStayInViewOnArrowKey = true;
            this.editAccordion.ResizeBarsStayInViewOnMouseDrag = true;
            this.editAccordion.ResizeBarsStayVisibleIfFocused = true;
            this.editAccordion.ResizeBarsTabStop = true;
            this.editAccordion.ShowPartiallyVisibleResizeBars = false;
            this.editAccordion.ShowToolMenu = true;
            this.editAccordion.ShowToolMenuOnHoverWhenClosed = false;
            this.editAccordion.ShowToolMenuOnRightClick = true;
            this.editAccordion.ShowToolMenuRequiresPositiveFillWeight = false;
            this.editAccordion.Size = new System.Drawing.Size(1101, 405);
            this.editAccordion.TabIndex = 0;
            this.editAccordion.UpArrow = null;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveChangesButton.AutoSize = true;
            this.saveChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saveChangesButton.Location = new System.Drawing.Point(455, 414);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(196, 41);
            this.saveChangesButton.TabIndex = 1;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // manageTabPage
            // 
            this.manageTabPage.Controls.Add(this.manageDataGridView);
            this.manageTabPage.Location = new System.Drawing.Point(4, 22);
            this.manageTabPage.Name = "manageTabPage";
            this.manageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manageTabPage.Size = new System.Drawing.Size(1113, 464);
            this.manageTabPage.TabIndex = 3;
            this.manageTabPage.Text = "Backup history";
            this.manageTabPage.UseVisualStyleBackColor = true;
            // 
            // manageDataGridView
            // 
            this.manageDataGridView.AllowUserToAddRows = false;
            this.manageDataGridView.AllowUserToDeleteRows = false;
            this.manageDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.manageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SourceColumn,
            this.DestinationColumn,
            this.DateColumn,
            this.ResultColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.manageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.manageDataGridView.Location = new System.Drawing.Point(3, 3);
            this.manageDataGridView.Name = "manageDataGridView";
            this.manageDataGridView.ReadOnly = true;
            this.manageDataGridView.RowHeadersVisible = false;
            this.manageDataGridView.Size = new System.Drawing.Size(1107, 458);
            this.manageDataGridView.TabIndex = 0;
            this.manageDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageDataGridView_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.FillWeight = 50F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SourceColumn
            // 
            this.SourceColumn.ActiveLinkColor = System.Drawing.Color.White;
            this.SourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SourceColumn.HeaderText = "Source path";
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            this.SourceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SourceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SourceColumn.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // DestinationColumn
            // 
            this.DestinationColumn.ActiveLinkColor = System.Drawing.Color.White;
            this.DestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DestinationColumn.HeaderText = "Destination path";
            this.DestinationColumn.Name = "DestinationColumn";
            this.DestinationColumn.ReadOnly = true;
            this.DestinationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DestinationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DestinationColumn.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.FillWeight = 50F;
            this.DateColumn.HeaderText = "Date-time";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // ResultColumn
            // 
            this.ResultColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResultColumn.FillWeight = 50F;
            this.ResultColumn.HeaderText = "Backup result";
            this.ResultColumn.Name = "ResultColumn";
            this.ResultColumn.ReadOnly = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.settingsParentTableLayoutPanel);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(1113, 464);
            this.settingsTabPage.TabIndex = 4;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsParentTableLayoutPanel
            // 
            this.settingsParentTableLayoutPanel.ColumnCount = 1;
            this.settingsParentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsParentTableLayoutPanel.Controls.Add(this.settingsTableLayoutPanel, 0, 0);
            this.settingsParentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsParentTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsParentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingsParentTableLayoutPanel.Name = "settingsParentTableLayoutPanel";
            this.settingsParentTableLayoutPanel.RowCount = 1;
            this.settingsParentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsParentTableLayoutPanel.Size = new System.Drawing.Size(1107, 458);
            this.settingsParentTableLayoutPanel.TabIndex = 1;
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.settingsTableLayoutPanel.AutoSize = true;
            this.settingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsTableLayoutPanel.ColumnCount = 2;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settingsTableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.settingsTableLayoutPanel.Controls.Add(this.saveSettingsButton, 0, 4);
            this.settingsTableLayoutPanel.Controls.Add(this.backupNameFormatLabel, 0, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.backupNameFormatTextBox, 1, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.backupNameFormatLinkLabel, 0, 1);
            this.settingsTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(301, 3);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 5;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(504, 452);
            this.settingsTableLayoutPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.settingsTableLayoutPanel.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(114, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contents of square brackets are only used\r\nwhen the folder name is a duplicate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveSettingsButton.AutoSize = true;
            this.saveSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsTableLayoutPanel.SetColumnSpan(this.saveSettingsButton, 2);
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saveSettingsButton.Location = new System.Drawing.Point(209, 408);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(86, 41);
            this.saveSettingsButton.TabIndex = 3;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // backupNameFormatLabel
            // 
            this.backupNameFormatLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backupNameFormatLabel.AutoSize = true;
            this.backupNameFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backupNameFormatLabel.Location = new System.Drawing.Point(3, 5);
            this.backupNameFormatLabel.Name = "backupNameFormatLabel";
            this.backupNameFormatLabel.Size = new System.Drawing.Size(142, 17);
            this.backupNameFormatLabel.TabIndex = 0;
            this.backupNameFormatLabel.Text = "Backup name format:";
            this.backupNameFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backupNameFormatTextBox
            // 
            this.backupNameFormatTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupNameFormatTextBox.Location = new System.Drawing.Point(151, 3);
            this.backupNameFormatTextBox.Name = "backupNameFormatTextBox";
            this.backupNameFormatTextBox.Size = new System.Drawing.Size(350, 22);
            this.backupNameFormatTextBox.TabIndex = 1;
            this.backupNameFormatTextBox.Text = "\'{name}\'_M-d-yyyy[_\'{duplicateNum}\']";
            this.backupNameFormatTextBox.TextChanged += new System.EventHandler(this.backupNameFormatTextBox_TextChanged);
            // 
            // backupNameFormatLinkLabel
            // 
            this.backupNameFormatLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backupNameFormatLinkLabel.AutoSize = true;
            this.settingsTableLayoutPanel.SetColumnSpan(this.backupNameFormatLinkLabel, 2);
            this.backupNameFormatLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backupNameFormatLinkLabel.Location = new System.Drawing.Point(178, 28);
            this.backupNameFormatLinkLabel.Name = "backupNameFormatLinkLabel";
            this.backupNameFormatLinkLabel.Size = new System.Drawing.Size(147, 17);
            this.backupNameFormatLinkLabel.TabIndex = 2;
            this.backupNameFormatLinkLabel.TabStop = true;
            this.backupNameFormatLinkLabel.Text = "Date format reference";
            this.backupNameFormatLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backupNameFormatLinkLabel_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.settingsTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.backupNameExtraLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 56);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(255, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "{name}\r\n{duplicateNum}\r\n[ ]";
            // 
            // backupNameExtraLabel
            // 
            this.backupNameExtraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backupNameExtraLabel.AutoSize = true;
            this.backupNameExtraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backupNameExtraLabel.Location = new System.Drawing.Point(68, 5);
            this.backupNameExtraLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.backupNameExtraLabel.Name = "backupNameExtraLabel";
            this.backupNameExtraLabel.Size = new System.Drawing.Size(181, 51);
            this.backupNameExtraLabel.TabIndex = 7;
            this.backupNameExtraLabel.Text = "Backup name =\r\nDuplicate backup number =\r\nDuplicate backup text =";
            this.backupNameExtraLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.aboutTableLayoutPanel);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(1113, 464);
            this.aboutTabPage.TabIndex = 5;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutTableLayoutPanel
            // 
            this.aboutTableLayoutPanel.ColumnCount = 1;
            this.aboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aboutTableLayoutPanel.Controls.Add(this.AboutInnerTableLayoutPanel, 0, 0);
            this.aboutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.aboutTableLayoutPanel.Name = "aboutTableLayoutPanel";
            this.aboutTableLayoutPanel.RowCount = 1;
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aboutTableLayoutPanel.Size = new System.Drawing.Size(1107, 458);
            this.aboutTableLayoutPanel.TabIndex = 0;
            // 
            // AboutInnerTableLayoutPanel
            // 
            this.AboutInnerTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutInnerTableLayoutPanel.AutoSize = true;
            this.AboutInnerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AboutInnerTableLayoutPanel.ColumnCount = 2;
            this.AboutInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AboutInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AboutInnerTableLayoutPanel.Controls.Add(this.label5, 0, 0);
            this.AboutInnerTableLayoutPanel.Controls.Add(this.label6, 0, 1);
            this.AboutInnerTableLayoutPanel.Controls.Add(this.emailLinkLabel, 1, 1);
            this.AboutInnerTableLayoutPanel.Controls.Add(this.label7, 0, 2);
            this.AboutInnerTableLayoutPanel.Controls.Add(this.linkLabel1, 1, 2);
            this.AboutInnerTableLayoutPanel.Location = new System.Drawing.Point(143, 120);
            this.AboutInnerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AboutInnerTableLayoutPanel.Name = "AboutInnerTableLayoutPanel";
            this.AboutInnerTableLayoutPanel.RowCount = 3;
            this.AboutInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutInnerTableLayoutPanel.Size = new System.Drawing.Size(821, 217);
            this.AboutInnerTableLayoutPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.AboutInnerTableLayoutPanel.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(815, 124);
            this.label5.TabIndex = 1;
            this.label5.Text = "EasyBackupTool\r\n\r\nCreated by Robert D. Rioja\r\n\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(68, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contact me at:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.emailLinkLabel.Location = new System.Drawing.Point(259, 124);
            this.emailLinkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(283, 31);
            this.emailLinkLabel.TabIndex = 3;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "miaweb.rr@gmail.com";
            this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLinkLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(0, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 62);
            this.label7.TabIndex = 4;
            this.label7.Text = "\r\nCode on my GitHub:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.linkLabel1.Location = new System.Drawing.Point(259, 186);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(562, 31);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/miapuffia/EasyBackupTool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Source path";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination path";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Backup result";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Backup result";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Include";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 490);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "EasyBackupTool";
            this.mainTabControl.ResumeLayout(false);
            this.backupTabPage.ResumeLayout(false);
            this.backupTableLayoutPanel.ResumeLayout(false);
            this.backupTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupsDataGridView)).EndInit();
            this.addBackupMessageTableLayoutPanel.ResumeLayout(false);
            this.addBackupMessageTableLayoutPanel.PerformLayout();
            this.addTabPage.ResumeLayout(false);
            this.addTableLayoutPanel.ResumeLayout(false);
            this.addTableLayoutPanel.PerformLayout();
            this.nameTableLayoutPanel.ResumeLayout(false);
            this.nameTableLayoutPanel.PerformLayout();
            this.editTabPage.ResumeLayout(false);
            this.editTableLayoutPanel.ResumeLayout(false);
            this.editTableLayoutPanel.PerformLayout();
            this.manageTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsParentTableLayoutPanel.ResumeLayout(false);
            this.settingsParentTableLayoutPanel.PerformLayout();
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.settingsTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTableLayoutPanel.ResumeLayout(false);
            this.aboutTableLayoutPanel.PerformLayout();
            this.AboutInnerTableLayoutPanel.ResumeLayout(false);
            this.AboutInnerTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage backupTabPage;
        private System.Windows.Forms.TableLayoutPanel backupTableLayoutPanel;
        private System.Windows.Forms.Button makeBackupsButton;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage editTabPage;
        private System.Windows.Forms.TabPage manageTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.DataGridView backupsDataGridView;
        private System.Windows.Forms.TableLayoutPanel addTableLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button pickSourceButton;
        private System.Windows.Forms.Button pickDetsinationButton;
        private System.Windows.Forms.Button addBackupButton;
        private System.Windows.Forms.TableLayoutPanel nameTableLayoutPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TableLayoutPanel editTableLayoutPanel;
        private Opulos.Core.UI.Accordion editAccordion;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TableLayoutPanel settingsParentTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
        private System.Windows.Forms.Label backupNameFormatLabel;
        private System.Windows.Forms.TextBox backupNameFormatTextBox;
        private System.Windows.Forms.LinkLabel backupNameFormatLinkLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private ProgressBarSample.TextProgressBar totalBackupsTextProgressBar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView manageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel addBackupMessageTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel addBackupLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label backupNameExtraLabel;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.TableLayoutPanel aboutTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel AboutInnerTableLayoutPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewLinkColumn SourceColumn;
        private System.Windows.Forms.DataGridViewLinkColumn DestinationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultColumn;
    }
}

