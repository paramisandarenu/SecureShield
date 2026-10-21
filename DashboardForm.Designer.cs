namespace SecureShield
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnHistory = new Button();
            btnFileScanner = new Button();
            btnPasswordAnalyzer = new Button();
            btnEmailScanner = new Button();
            btnURLScanner = new Button();
            btnDashboard = new Button();
            lblSidebarTitle = new Label();
            lblSidebarShield = new Label();
            lblWelcome = new Label();
            lblDashboardSubtitle = new Label();
            pnlTotalScans = new Panel();
            picTotalScans = new PictureBox();
            lblTotalScansValue = new Label();
            lblTotalScansTitle = new Label();
            pnlThreats = new Panel();
            pnlUserInfo = new Panel();
            txtConfirmNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            btnCancelProfile = new Button();
            btnSaveProfile = new Button();
            txtProfilePassword = new TextBox();
            txtProfileEmail = new TextBox();
            txtProfileUsername = new TextBox();
            txtProfileFullName = new TextBox();
            lblProfilePassword = new Label();
            lblProfileEmail = new Label();
            lblProfileUsername = new Label();
            lblProfileFullName = new Label();
            lblProfileTitle = new Label();
            picThreats = new PictureBox();
            lblThreatsValue = new Label();
            lblThreatsTitle = new Label();
            pnlSafeURLs = new Panel();
            picSafeURLs = new PictureBox();
            lblSafeURLsValue = new Label();
            lblSafeURLsTitle = new Label();
            pnlRiskScore = new Panel();
            picRiskScore = new PictureBox();
            lblRiskScoreValue = new Label();
            lblRiskScoreTitle = new Label();
            lblUserName = new Label();
            picUser = new PictureBox();
            lblProfileName = new Label();
            lblProfileArrow = new Label();
            pnlProfile = new Panel();
            pnlSecurityOverview = new Panel();
            pnlThreatDistribution = new Panel();
            lblThreatCount = new Label();
            lblSuspiciousCount = new Label();
            lblSafeCount = new Label();
            lblThreatDistribution = new Label();
            pictureBox1 = new PictureBox();
            pnlScanActivity = new Panel();
            lblScanActivityData = new Label();
            lblScanActivity = new Label();
            lblSecurityOverview = new Label();
            pnlRecentScans = new Panel();
            dgvRecentScans = new DataGridView();
            colScanTarget = new DataGridViewTextBoxColumn();
            colScanType = new DataGridViewTextBoxColumn();
            colScanResult = new DataGridViewTextBoxColumn();
            colScanDate = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            lblRecentScansTitle = new Label();
            pnlQuickScan = new Panel();
            btnQuickScan = new Button();
            txtQuickScanUrl = new TextBox();
            lblQuickScanTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlTotalScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalScans).BeginInit();
            pnlThreats.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThreats).BeginInit();
            pnlSafeURLs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSafeURLs).BeginInit();
            pnlRiskScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRiskScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlSecurityOverview.SuspendLayout();
            pnlThreatDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlScanActivity.SuspendLayout();
            pnlRecentScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentScans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlQuickScan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 24, 39);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnFileScanner);
            pnlSidebar.Controls.Add(btnPasswordAnalyzer);
            pnlSidebar.Controls.Add(btnEmailScanner);
            pnlSidebar.Controls.Add(btnURLScanner);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSidebarTitle);
            pnlSidebar.Controls.Add(lblSidebarShield);
            pnlSidebar.Location = new Point(7, 12);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(236, 742);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(249, 250, 251);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 630);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(210, 45);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(249, 250, 251);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(12, 532);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(210, 45);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.FromArgb(249, 250, 251);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(12, 481);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(15, 0, 0, 0);
            btnReports.Size = new Size(210, 45);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(249, 250, 251);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(12, 430);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(15, 0, 0, 0);
            btnHistory.Size = new Size(210, 45);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "Security History";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += button4_Click;
            // 
            // btnFileScanner
            // 
            btnFileScanner.FlatAppearance.BorderSize = 0;
            btnFileScanner.FlatStyle = FlatStyle.Flat;
            btnFileScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnFileScanner.Image = (Image)resources.GetObject("btnFileScanner.Image");
            btnFileScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnFileScanner.Location = new Point(9, 379);
            btnFileScanner.Name = "btnFileScanner";
            btnFileScanner.Padding = new Padding(15, 0, 0, 0);
            btnFileScanner.Size = new Size(210, 45);
            btnFileScanner.TabIndex = 6;
            btnFileScanner.Text = "File Scanner";
            btnFileScanner.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFileScanner.UseVisualStyleBackColor = false;
            // 
            // btnPasswordAnalyzer
            // 
            btnPasswordAnalyzer.FlatAppearance.BorderSize = 0;
            btnPasswordAnalyzer.FlatStyle = FlatStyle.Flat;
            btnPasswordAnalyzer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPasswordAnalyzer.ForeColor = Color.FromArgb(249, 250, 251);
            btnPasswordAnalyzer.Image = (Image)resources.GetObject("btnPasswordAnalyzer.Image");
            btnPasswordAnalyzer.ImageAlign = ContentAlignment.MiddleLeft;
            btnPasswordAnalyzer.Location = new Point(9, 328);
            btnPasswordAnalyzer.Name = "btnPasswordAnalyzer";
            btnPasswordAnalyzer.Padding = new Padding(15, 0, 0, 0);
            btnPasswordAnalyzer.Size = new Size(210, 45);
            btnPasswordAnalyzer.TabIndex = 5;
            btnPasswordAnalyzer.Text = "Password Analyzer";
            btnPasswordAnalyzer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPasswordAnalyzer.UseVisualStyleBackColor = false;
            // 
            // btnEmailScanner
            // 
            btnEmailScanner.FlatAppearance.BorderSize = 0;
            btnEmailScanner.FlatStyle = FlatStyle.Flat;
            btnEmailScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmailScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnEmailScanner.Image = (Image)resources.GetObject("btnEmailScanner.Image");
            btnEmailScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmailScanner.Location = new Point(10, 277);
            btnEmailScanner.Name = "btnEmailScanner";
            btnEmailScanner.Padding = new Padding(15, 0, 0, 0);
            btnEmailScanner.Size = new Size(210, 45);
            btnEmailScanner.TabIndex = 4;
            btnEmailScanner.Text = "Email Scanner";
            btnEmailScanner.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmailScanner.UseVisualStyleBackColor = false;
            // 
            // btnURLScanner
            // 
            btnURLScanner.FlatAppearance.BorderSize = 0;
            btnURLScanner.FlatStyle = FlatStyle.Flat;
            btnURLScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnURLScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnURLScanner.Image = (Image)resources.GetObject("btnURLScanner.Image");
            btnURLScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnURLScanner.Location = new Point(12, 226);
            btnURLScanner.Name = "btnURLScanner";
            btnURLScanner.Padding = new Padding(15, 0, 0, 0);
            btnURLScanner.Size = new Size(210, 45);
            btnURLScanner.TabIndex = 3;
            btnURLScanner.Text = "URL Scanner";
            btnURLScanner.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnURLScanner.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(37, 99, 235);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(249, 250, 251);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 153);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(210, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.AutoSize = true;
            lblSidebarTitle.BackColor = Color.Transparent;
            lblSidebarTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSidebarTitle.ForeColor = Color.FromArgb(249, 250, 251);
            lblSidebarTitle.Location = new Point(21, 76);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(199, 41);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "SecureShield";
            // 
            // lblSidebarShield
            // 
            lblSidebarShield.AutoSize = true;
            lblSidebarShield.BackColor = Color.Transparent;
            lblSidebarShield.Font = new Font("Segoe UI Emoji", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSidebarShield.ForeColor = Color.FromArgb(37, 99, 235);
            lblSidebarShield.Location = new Point(67, 13);
            lblSidebarShield.Name = "lblSidebarShield";
            lblSidebarShield.Size = new Size(92, 63);
            lblSidebarShield.TabIndex = 0;
            lblSidebarShield.Text = "🛡";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(249, 250, 251);
            lblWelcome.Location = new Point(285, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(237, 41);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome back ,";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblDashboardSubtitle.Location = new Point(286, 56);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(332, 25);
            lblDashboardSubtitle.TabIndex = 2;
            lblDashboardSubtitle.Text = "Monitor and analyze your security status";
            // 
            // pnlTotalScans
            // 
            pnlTotalScans.BackColor = Color.FromArgb(31, 41, 55);
            pnlTotalScans.Controls.Add(picTotalScans);
            pnlTotalScans.Controls.Add(lblTotalScansValue);
            pnlTotalScans.Controls.Add(lblTotalScansTitle);
            pnlTotalScans.Location = new Point(285, 105);
            pnlTotalScans.Name = "pnlTotalScans";
            pnlTotalScans.Size = new Size(190, 105);
            pnlTotalScans.TabIndex = 3;
            // 
            // picTotalScans
            // 
            picTotalScans.BackColor = Color.Transparent;
            picTotalScans.Image = (Image)resources.GetObject("picTotalScans.Image");
            picTotalScans.Location = new Point(15, 12);
            picTotalScans.Name = "picTotalScans";
            picTotalScans.Size = new Size(32, 32);
            picTotalScans.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalScans.TabIndex = 2;
            picTotalScans.TabStop = false;
            // 
            // lblTotalScansValue
            // 
            lblTotalScansValue.AutoSize = true;
            lblTotalScansValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalScansValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblTotalScansValue.Location = new Point(68, 40);
            lblTotalScansValue.Name = "lblTotalScansValue";
            lblTotalScansValue.Size = new Size(50, 60);
            lblTotalScansValue.TabIndex = 1;
            lblTotalScansValue.Text = "0";
            // 
            // lblTotalScansTitle
            // 
            lblTotalScansTitle.AutoSize = true;
            lblTotalScansTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalScansTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblTotalScansTitle.Location = new Point(66, 19);
            lblTotalScansTitle.Name = "lblTotalScansTitle";
            lblTotalScansTitle.Size = new Size(94, 23);
            lblTotalScansTitle.TabIndex = 0;
            lblTotalScansTitle.Text = "Total Scans";
            // 
            // pnlThreats
            // 
            pnlThreats.BackColor = Color.FromArgb(31, 41, 55);
            pnlThreats.Controls.Add(picThreats);
            pnlThreats.Controls.Add(lblThreatsValue);
            pnlThreats.Controls.Add(lblThreatsTitle);
            pnlThreats.Location = new Point(530, 105);
            pnlThreats.Name = "pnlThreats";
            pnlThreats.Size = new Size(190, 105);
            pnlThreats.TabIndex = 4;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(31, 41, 55);
            pnlUserInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlUserInfo.Controls.Add(txtConfirmNewPassword);
            pnlUserInfo.Controls.Add(lblConfirmNewPassword);
            pnlUserInfo.Controls.Add(txtCurrentPassword);
            pnlUserInfo.Controls.Add(lblCurrentPassword);
            pnlUserInfo.Controls.Add(btnCancelProfile);
            pnlUserInfo.Controls.Add(btnSaveProfile);
            pnlUserInfo.Controls.Add(txtProfilePassword);
            pnlUserInfo.Controls.Add(txtProfileEmail);
            pnlUserInfo.Controls.Add(txtProfileUsername);
            pnlUserInfo.Controls.Add(txtProfileFullName);
            pnlUserInfo.Controls.Add(lblProfilePassword);
            pnlUserInfo.Controls.Add(lblProfileEmail);
            pnlUserInfo.Controls.Add(lblProfileUsername);
            pnlUserInfo.Controls.Add(lblProfileFullName);
            pnlUserInfo.Controls.Add(lblProfileTitle);
            pnlUserInfo.Location = new Point(914, 78);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(313, 580);
            pnlUserInfo.TabIndex = 12;
            pnlUserInfo.Visible = false;
            pnlUserInfo.Paint += pnlUserInfo_Paint;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = Color.FromArgb(17, 24, 39);
            txtConfirmNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmNewPassword.ForeColor = Color.FromArgb(249, 250, 251);
            txtConfirmNewPassword.Location = new Point(18, 455);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '●';
            txtConfirmNewPassword.Size = new Size(250, 27);
            txtConfirmNewPassword.TabIndex = 17;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.ForeColor = Color.FromArgb(148, 163, 184);
            lblConfirmNewPassword.Location = new Point(18, 429);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(161, 20);
            lblConfirmNewPassword.TabIndex = 16;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(17, 24, 39);
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.ForeColor = Color.FromArgb(249, 250, 251);
            txtCurrentPassword.Location = new Point(18, 302);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '●';
            txtCurrentPassword.Size = new Size(250, 27);
            txtCurrentPassword.TabIndex = 15;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.ForeColor = Color.FromArgb(148, 163, 184);
            lblCurrentPassword.Location = new Point(18, 276);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(122, 20);
            lblCurrentPassword.TabIndex = 14;
            lblCurrentPassword.Text = "Current Password";
            // 
            // btnCancelProfile
            // 
            btnCancelProfile.BackColor = Color.FromArgb(55, 65, 81);
            btnCancelProfile.FlatAppearance.BorderSize = 0;
            btnCancelProfile.FlatStyle = FlatStyle.Flat;
            btnCancelProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelProfile.ForeColor = Color.FromArgb(249, 250, 251);
            btnCancelProfile.Location = new Point(178, 508);
            btnCancelProfile.Name = "btnCancelProfile";
            btnCancelProfile.Size = new Size(90, 35);
            btnCancelProfile.TabIndex = 13;
            btnCancelProfile.Text = "Cancel";
            btnCancelProfile.UseVisualStyleBackColor = false;
            btnCancelProfile.Click += btnCancelProfile_Click;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveProfile.FlatAppearance.BorderSize = 0;
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProfile.ForeColor = Color.FromArgb(249, 250, 251);
            btnSaveProfile.Location = new Point(20, 508);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(120, 35);
            btnSaveProfile.TabIndex = 12;
            btnSaveProfile.Text = "Save Changes";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // txtProfilePassword
            // 
            txtProfilePassword.BackColor = Color.FromArgb(17, 24, 39);
            txtProfilePassword.BorderStyle = BorderStyle.FixedSingle;
            txtProfilePassword.ForeColor = Color.FromArgb(249, 250, 251);
            txtProfilePassword.Location = new Point(18, 376);
            txtProfilePassword.Name = "txtProfilePassword";
            txtProfilePassword.PasswordChar = '●';
            txtProfilePassword.Size = new Size(250, 27);
            txtProfilePassword.TabIndex = 11;
            txtProfilePassword.TextChanged += textBox1_TextChanged;
            // 
            // txtProfileEmail
            // 
            txtProfileEmail.BackColor = Color.FromArgb(17, 24, 39);
            txtProfileEmail.BorderStyle = BorderStyle.FixedSingle;
            txtProfileEmail.ForeColor = Color.FromArgb(249, 250, 251);
            txtProfileEmail.Location = new Point(17, 222);
            txtProfileEmail.Name = "txtProfileEmail";
            txtProfileEmail.Size = new Size(250, 27);
            txtProfileEmail.TabIndex = 10;
            // 
            // txtProfileUsername
            // 
            txtProfileUsername.BackColor = Color.FromArgb(17, 24, 39);
            txtProfileUsername.BorderStyle = BorderStyle.FixedSingle;
            txtProfileUsername.ForeColor = Color.FromArgb(249, 250, 251);
            txtProfileUsername.Location = new Point(17, 154);
            txtProfileUsername.Name = "txtProfileUsername";
            txtProfileUsername.Size = new Size(250, 27);
            txtProfileUsername.TabIndex = 9;
            // 
            // txtProfileFullName
            // 
            txtProfileFullName.BackColor = Color.FromArgb(17, 24, 39);
            txtProfileFullName.BorderStyle = BorderStyle.FixedSingle;
            txtProfileFullName.ForeColor = Color.FromArgb(249, 250, 251);
            txtProfileFullName.Location = new Point(17, 85);
            txtProfileFullName.Name = "txtProfileFullName";
            txtProfileFullName.Size = new Size(250, 27);
            txtProfileFullName.TabIndex = 8;
            // 
            // lblProfilePassword
            // 
            lblProfilePassword.AutoSize = true;
            lblProfilePassword.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfilePassword.Location = new Point(18, 353);
            lblProfilePassword.Name = "lblProfilePassword";
            lblProfilePassword.Size = new Size(104, 20);
            lblProfilePassword.TabIndex = 7;
            lblProfilePassword.Text = "New Password";
            // 
            // lblProfileEmail
            // 
            lblProfileEmail.AutoSize = true;
            lblProfileEmail.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileEmail.Location = new Point(17, 199);
            lblProfileEmail.Name = "lblProfileEmail";
            lblProfileEmail.Size = new Size(46, 20);
            lblProfileEmail.TabIndex = 5;
            lblProfileEmail.Text = "Email";
            // 
            // lblProfileUsername
            // 
            lblProfileUsername.AutoSize = true;
            lblProfileUsername.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileUsername.Location = new Point(17, 131);
            lblProfileUsername.Name = "lblProfileUsername";
            lblProfileUsername.Size = new Size(75, 20);
            lblProfileUsername.TabIndex = 3;
            lblProfileUsername.Text = "Username";
            // 
            // lblProfileFullName
            // 
            lblProfileFullName.AutoSize = true;
            lblProfileFullName.BackColor = Color.Transparent;
            lblProfileFullName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileFullName.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileFullName.Location = new Point(14, 62);
            lblProfileFullName.Name = "lblProfileFullName";
            lblProfileFullName.Size = new Size(76, 20);
            lblProfileFullName.TabIndex = 1;
            lblProfileFullName.Text = "Full Name";
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.AutoSize = true;
            lblProfileTitle.BackColor = Color.Transparent;
            lblProfileTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileTitle.ForeColor = Color.FromArgb(249, 250, 251);
            lblProfileTitle.Location = new Point(17, 16);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(165, 31);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "👤 My Profile";
            lblProfileTitle.Click += lblProfileTitle_Click;
            // 
            // picThreats
            // 
            picThreats.BackColor = Color.Transparent;
            picThreats.Image = (Image)resources.GetObject("picThreats.Image");
            picThreats.Location = new Point(9, 12);
            picThreats.Name = "picThreats";
            picThreats.Size = new Size(32, 32);
            picThreats.SizeMode = PictureBoxSizeMode.Zoom;
            picThreats.TabIndex = 2;
            picThreats.TabStop = false;
            // 
            // lblThreatsValue
            // 
            lblThreatsValue.AutoSize = true;
            lblThreatsValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThreatsValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblThreatsValue.Location = new Point(72, 42);
            lblThreatsValue.Name = "lblThreatsValue";
            lblThreatsValue.Size = new Size(50, 60);
            lblThreatsValue.TabIndex = 1;
            lblThreatsValue.Text = "0";
            // 
            // lblThreatsTitle
            // 
            lblThreatsTitle.AutoSize = true;
            lblThreatsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThreatsTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblThreatsTitle.Location = new Point(47, 19);
            lblThreatsTitle.Name = "lblThreatsTitle";
            lblThreatsTitle.Size = new Size(140, 23);
            lblThreatsTitle.TabIndex = 0;
            lblThreatsTitle.Text = "Threats Detected";
            // 
            // pnlSafeURLs
            // 
            pnlSafeURLs.BackColor = Color.FromArgb(31, 41, 55);
            pnlSafeURLs.Controls.Add(picSafeURLs);
            pnlSafeURLs.Controls.Add(lblSafeURLsValue);
            pnlSafeURLs.Controls.Add(lblSafeURLsTitle);
            pnlSafeURLs.Location = new Point(786, 105);
            pnlSafeURLs.Name = "pnlSafeURLs";
            pnlSafeURLs.Size = new Size(184, 105);
            pnlSafeURLs.TabIndex = 5;
            // 
            // picSafeURLs
            // 
            picSafeURLs.BackColor = Color.Transparent;
            picSafeURLs.Image = (Image)resources.GetObject("picSafeURLs.Image");
            picSafeURLs.Location = new Point(15, 12);
            picSafeURLs.Name = "picSafeURLs";
            picSafeURLs.Size = new Size(32, 32);
            picSafeURLs.SizeMode = PictureBoxSizeMode.Zoom;
            picSafeURLs.TabIndex = 2;
            picSafeURLs.TabStop = false;
            // 
            // lblSafeURLsValue
            // 
            lblSafeURLsValue.AutoSize = true;
            lblSafeURLsValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSafeURLsValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblSafeURLsValue.Location = new Point(82, 40);
            lblSafeURLsValue.Name = "lblSafeURLsValue";
            lblSafeURLsValue.Size = new Size(50, 60);
            lblSafeURLsValue.TabIndex = 1;
            lblSafeURLsValue.Text = "0";
            // 
            // lblSafeURLsTitle
            // 
            lblSafeURLsTitle.AutoSize = true;
            lblSafeURLsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSafeURLsTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSafeURLsTitle.Location = new Point(66, 19);
            lblSafeURLsTitle.Name = "lblSafeURLsTitle";
            lblSafeURLsTitle.Size = new Size(84, 23);
            lblSafeURLsTitle.TabIndex = 0;
            lblSafeURLsTitle.Text = "Safe URLs";
            // 
            // pnlRiskScore
            // 
            pnlRiskScore.BackColor = Color.FromArgb(31, 41, 55);
            pnlRiskScore.Controls.Add(picRiskScore);
            pnlRiskScore.Controls.Add(lblRiskScoreValue);
            pnlRiskScore.Controls.Add(lblRiskScoreTitle);
            pnlRiskScore.Location = new Point(1037, 105);
            pnlRiskScore.Name = "pnlRiskScore";
            pnlRiskScore.Size = new Size(190, 105);
            pnlRiskScore.TabIndex = 6;
            // 
            // picRiskScore
            // 
            picRiskScore.BackColor = Color.Transparent;
            picRiskScore.Image = (Image)resources.GetObject("picRiskScore.Image");
            picRiskScore.Location = new Point(15, 12);
            picRiskScore.Name = "picRiskScore";
            picRiskScore.Size = new Size(32, 32);
            picRiskScore.SizeMode = PictureBoxSizeMode.Zoom;
            picRiskScore.TabIndex = 2;
            picRiskScore.TabStop = false;
            // 
            // lblRiskScoreValue
            // 
            lblRiskScoreValue.AutoSize = true;
            lblRiskScoreValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiskScoreValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblRiskScoreValue.Location = new Point(32, 42);
            lblRiskScoreValue.Name = "lblRiskScoreValue";
            lblRiskScoreValue.Size = new Size(138, 60);
            lblRiskScoreValue.TabIndex = 1;
            lblRiskScoreValue.Text = "100%";
            // 
            // lblRiskScoreTitle
            // 
            lblRiskScoreTitle.AutoSize = true;
            lblRiskScoreTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRiskScoreTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblRiskScoreTitle.Location = new Point(53, 21);
            lblRiskScoreTitle.Name = "lblRiskScoreTitle";
            lblRiskScoreTitle.Size = new Size(117, 23);
            lblRiskScoreTitle.TabIndex = 0;
            lblRiskScoreTitle.Text = "Security Score";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(59, 130, 246);
            lblUserName.Location = new Point(528, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 41);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "User";
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(1018, 19);
            picUser.Name = "picUser";
            picUser.Size = new Size(28, 28);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 8;
            picUser.TabStop = false;
            picUser.Click += pnlProfile_Click;
            // 
            // lblProfileName
            // 
            lblProfileName.AutoEllipsis = true;
            lblProfileName.BackColor = Color.Transparent;
            lblProfileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileName.ForeColor = Color.FromArgb(249, 250, 251);
            lblProfileName.Location = new Point(1052, 22);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(150, 25);
            lblProfileName.TabIndex = 9;
            lblProfileName.Text = "User";
            lblProfileName.TextAlign = ContentAlignment.MiddleLeft;
            lblProfileName.Click += pnlProfile_Click;
            // 
            // lblProfileArrow
            // 
            lblProfileArrow.AutoSize = true;
            lblProfileArrow.BackColor = Color.Transparent;
            lblProfileArrow.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileArrow.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileArrow.Location = new Point(1208, 30);
            lblProfileArrow.Name = "lblProfileArrow";
            lblProfileArrow.Size = new Size(19, 17);
            lblProfileArrow.TabIndex = 10;
            lblProfileArrow.Text = "▼";
            lblProfileArrow.Click += pnlProfile_Click;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Transparent;
            pnlProfile.Location = new Point(672, 24);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(77, 61);
            pnlProfile.TabIndex = 11;
            pnlProfile.Visible = false;
            pnlProfile.Click += pnlProfile_Click;
            // 
            // pnlSecurityOverview
            // 
            pnlSecurityOverview.BackColor = Color.FromArgb(31, 41, 55);
            pnlSecurityOverview.BorderStyle = BorderStyle.FixedSingle;
            pnlSecurityOverview.Controls.Add(pnlThreatDistribution);
            pnlSecurityOverview.Controls.Add(pictureBox1);
            pnlSecurityOverview.Controls.Add(pnlScanActivity);
            pnlSecurityOverview.Controls.Add(lblSecurityOverview);
            pnlSecurityOverview.Location = new Point(286, 243);
            pnlSecurityOverview.Name = "pnlSecurityOverview";
            pnlSecurityOverview.Size = new Size(941, 231);
            pnlSecurityOverview.TabIndex = 13;
            pnlSecurityOverview.Paint += panel1_Paint;
            // 
            // pnlThreatDistribution
            // 
            pnlThreatDistribution.BackColor = Color.FromArgb(17, 24, 39);
            pnlThreatDistribution.BorderStyle = BorderStyle.FixedSingle;
            pnlThreatDistribution.Controls.Add(lblThreatCount);
            pnlThreatDistribution.Controls.Add(lblSuspiciousCount);
            pnlThreatDistribution.Controls.Add(lblSafeCount);
            pnlThreatDistribution.Controls.Add(lblThreatDistribution);
            pnlThreatDistribution.Location = new Point(499, 60);
            pnlThreatDistribution.Name = "pnlThreatDistribution";
            pnlThreatDistribution.Size = new Size(367, 159);
            pnlThreatDistribution.TabIndex = 2;
            // 
            // lblThreatCount
            // 
            lblThreatCount.AutoSize = true;
            lblThreatCount.BackColor = Color.Transparent;
            lblThreatCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThreatCount.ForeColor = Color.FromArgb(239, 68, 68);
            lblThreatCount.Location = new Point(22, 122);
            lblThreatCount.Name = "lblThreatCount";
            lblThreatCount.Size = new Size(112, 23);
            lblThreatCount.TabIndex = 3;
            lblThreatCount.Text = "🔴 Threats: 0";
            // 
            // lblSuspiciousCount
            // 
            lblSuspiciousCount.AutoSize = true;
            lblSuspiciousCount.BackColor = Color.Transparent;
            lblSuspiciousCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuspiciousCount.ForeColor = Color.FromArgb(245, 158, 11);
            lblSuspiciousCount.Location = new Point(22, 84);
            lblSuspiciousCount.Name = "lblSuspiciousCount";
            lblSuspiciousCount.Size = new Size(135, 23);
            lblSuspiciousCount.TabIndex = 2;
            lblSuspiciousCount.Text = "\U0001f7e1 Suspicious: 0";
            // 
            // lblSafeCount
            // 
            lblSafeCount.AutoSize = true;
            lblSafeCount.BackColor = Color.Transparent;
            lblSafeCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSafeCount.ForeColor = Color.FromArgb(34, 197, 94);
            lblSafeCount.Location = new Point(22, 44);
            lblSafeCount.Name = "lblSafeCount";
            lblSafeCount.Size = new Size(88, 23);
            lblSafeCount.TabIndex = 1;
            lblSafeCount.Text = "\U0001f7e2 Safe: 0";
            // 
            // lblThreatDistribution
            // 
            lblThreatDistribution.AutoSize = true;
            lblThreatDistribution.BackColor = Color.Transparent;
            lblThreatDistribution.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThreatDistribution.ForeColor = Color.FromArgb(249, 250, 251);
            lblThreatDistribution.Location = new Point(15, 12);
            lblThreatDistribution.Name = "lblThreatDistribution";
            lblThreatDistribution.Size = new Size(174, 25);
            lblThreatDistribution.TabIndex = 0;
            lblThreatDistribution.Text = "Threat Distribution";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlScanActivity
            // 
            pnlScanActivity.BackColor = Color.FromArgb(17, 24, 39);
            pnlScanActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlScanActivity.Controls.Add(lblScanActivityData);
            pnlScanActivity.Controls.Add(lblScanActivity);
            pnlScanActivity.Location = new Point(67, 60);
            pnlScanActivity.Name = "pnlScanActivity";
            pnlScanActivity.Size = new Size(367, 159);
            pnlScanActivity.TabIndex = 1;
            pnlScanActivity.Paint += pnlScanActivity_Paint;
            // 
            // lblScanActivityData
            // 
            lblScanActivityData.AutoSize = true;
            lblScanActivityData.BackColor = Color.Transparent;
            lblScanActivityData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScanActivityData.ForeColor = Color.FromArgb(148, 163, 184);
            lblScanActivityData.Location = new Point(15, 70);
            lblScanActivityData.Name = "lblScanActivityData";
            lblScanActivityData.Size = new Size(182, 23);
            lblScanActivityData.TabIndex = 1;
            lblScanActivityData.Text = "No scan data available";
            // 
            // lblScanActivity
            // 
            lblScanActivity.AutoSize = true;
            lblScanActivity.BackColor = Color.Transparent;
            lblScanActivity.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScanActivity.ForeColor = Color.FromArgb(249, 250, 251);
            lblScanActivity.Location = new Point(15, 12);
            lblScanActivity.Name = "lblScanActivity";
            lblScanActivity.Size = new Size(123, 25);
            lblScanActivity.TabIndex = 0;
            lblScanActivity.Text = "Scan Activity";
            // 
            // lblSecurityOverview
            // 
            lblSecurityOverview.AutoSize = true;
            lblSecurityOverview.BackColor = Color.Transparent;
            lblSecurityOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecurityOverview.ForeColor = Color.FromArgb(249, 250, 251);
            lblSecurityOverview.ImageAlign = ContentAlignment.MiddleLeft;
            lblSecurityOverview.Location = new Point(67, 18);
            lblSecurityOverview.Name = "lblSecurityOverview";
            lblSecurityOverview.Size = new Size(207, 31);
            lblSecurityOverview.TabIndex = 0;
            lblSecurityOverview.Text = "Security Overview";
            lblSecurityOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRecentScans
            // 
            pnlRecentScans.BackColor = Color.FromArgb(31, 41, 55);
            pnlRecentScans.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentScans.Controls.Add(dgvRecentScans);
            pnlRecentScans.Controls.Add(pictureBox2);
            pnlRecentScans.Controls.Add(lblRecentScansTitle);
            pnlRecentScans.Location = new Point(285, 508);
            pnlRecentScans.Name = "pnlRecentScans";
            pnlRecentScans.Size = new Size(942, 138);
            pnlRecentScans.TabIndex = 14;
            pnlRecentScans.Paint += panel1_Paint_2;
            // 
            // dgvRecentScans
            // 
            dgvRecentScans.AllowUserToAddRows = false;
            dgvRecentScans.AllowUserToDeleteRows = false;
            dgvRecentScans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentScans.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvRecentScans.BorderStyle = BorderStyle.None;
            dgvRecentScans.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentScans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentScans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentScans.Columns.AddRange(new DataGridViewColumn[] { colScanTarget, colScanType, colScanResult, colScanDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentScans.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentScans.EnableHeadersVisualStyles = false;
            dgvRecentScans.GridColor = Color.FromArgb(55, 65, 81);
            dgvRecentScans.Location = new Point(68, 53);
            dgvRecentScans.MultiSelect = false;
            dgvRecentScans.Name = "dgvRecentScans";
            dgvRecentScans.ReadOnly = true;
            dgvRecentScans.RowHeadersVisible = false;
            dgvRecentScans.RowHeadersWidth = 51;
            dgvRecentScans.RowTemplate.Height = 35;
            dgvRecentScans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentScans.Size = new Size(814, 80);
            dgvRecentScans.TabIndex = 3;
            // 
            // colScanTarget
            // 
            colScanTarget.HeaderText = "URL / File";
            colScanTarget.MinimumWidth = 6;
            colScanTarget.Name = "colScanTarget";
            colScanTarget.ReadOnly = true;
            // 
            // colScanType
            // 
            colScanType.HeaderText = "Scan Type";
            colScanType.MinimumWidth = 6;
            colScanType.Name = "colScanType";
            colScanType.ReadOnly = true;
            // 
            // colScanResult
            // 
            colScanResult.HeaderText = "Result";
            colScanResult.MinimumWidth = 6;
            colScanResult.Name = "colScanResult";
            colScanResult.ReadOnly = true;
            // 
            // colScanDate
            // 
            colScanDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colScanDate.HeaderText = "Date / Time";
            colScanDate.MinimumWidth = 6;
            colScanDate.Name = "colScanDate";
            colScanDate.ReadOnly = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblRecentScansTitle
            // 
            lblRecentScansTitle.AutoSize = true;
            lblRecentScansTitle.BackColor = Color.Transparent;
            lblRecentScansTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentScansTitle.ForeColor = Color.FromArgb(249, 250, 251);
            lblRecentScansTitle.Location = new Point(67, 9);
            lblRecentScansTitle.Name = "lblRecentScansTitle";
            lblRecentScansTitle.Size = new Size(152, 31);
            lblRecentScansTitle.TabIndex = 0;
            lblRecentScansTitle.Text = "Recent Scans";
            lblRecentScansTitle.Click += lblRecentScansTitle_Click;
            // 
            // pnlQuickScan
            // 
            pnlQuickScan.BackColor = Color.FromArgb(31, 41, 55);
            pnlQuickScan.BorderStyle = BorderStyle.FixedSingle;
            pnlQuickScan.Controls.Add(btnQuickScan);
            pnlQuickScan.Controls.Add(txtQuickScanUrl);
            pnlQuickScan.Controls.Add(lblQuickScanTitle);
            pnlQuickScan.Location = new Point(286, 664);
            pnlQuickScan.Name = "pnlQuickScan";
            pnlQuickScan.Size = new Size(941, 90);
            pnlQuickScan.TabIndex = 15;
            // 
            // btnQuickScan
            // 
            btnQuickScan.BackColor = Color.FromArgb(37, 99, 235);
            btnQuickScan.Cursor = Cursors.Hand;
            btnQuickScan.FlatAppearance.BorderSize = 0;
            btnQuickScan.FlatStyle = FlatStyle.Flat;
            btnQuickScan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickScan.ForeColor = SystemColors.Control;
            btnQuickScan.Location = new Point(732, 47);
            btnQuickScan.Name = "btnQuickScan";
            btnQuickScan.Size = new Size(149, 29);
            btnQuickScan.TabIndex = 2;
            btnQuickScan.Text = "Scan URL";
            btnQuickScan.UseVisualStyleBackColor = false;
            // 
            // txtQuickScanUrl
            // 
            txtQuickScanUrl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuickScanUrl.Location = new Point(28, 46);
            txtQuickScanUrl.Name = "txtQuickScanUrl";
            txtQuickScanUrl.PlaceholderText = "Enter a URL to scan...";
            txtQuickScanUrl.Size = new Size(676, 30);
            txtQuickScanUrl.TabIndex = 1;
            // 
            // lblQuickScanTitle
            // 
            lblQuickScanTitle.AutoSize = true;
            lblQuickScanTitle.BackColor = Color.Transparent;
            lblQuickScanTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickScanTitle.ForeColor = Color.FromArgb(249, 250, 251);
            lblQuickScanTitle.Location = new Point(29, 0);
            lblQuickScanTitle.Name = "lblQuickScanTitle";
            lblQuickScanTitle.Size = new Size(132, 31);
            lblQuickScanTitle.TabIndex = 0;
            lblQuickScanTitle.Text = "Quick Scan";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 17, 32);
            ClientSize = new Size(1277, 766);
            Controls.Add(pnlUserInfo);
            Controls.Add(pnlQuickScan);
            Controls.Add(pnlRecentScans);
            Controls.Add(pnlSecurityOverview);
            Controls.Add(pnlProfile);
            Controls.Add(lblProfileArrow);
            Controls.Add(lblProfileName);
            Controls.Add(picUser);
            Controls.Add(lblUserName);
            Controls.Add(pnlRiskScore);
            Controls.Add(pnlSafeURLs);
            Controls.Add(pnlThreats);
            Controls.Add(pnlTotalScans);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - Dashboard";
            Load += DashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlTotalScans.ResumeLayout(false);
            pnlTotalScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalScans).EndInit();
            pnlThreats.ResumeLayout(false);
            pnlThreats.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picThreats).EndInit();
            pnlSafeURLs.ResumeLayout(false);
            pnlSafeURLs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSafeURLs).EndInit();
            pnlRiskScore.ResumeLayout(false);
            pnlRiskScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRiskScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlSecurityOverview.ResumeLayout(false);
            pnlSecurityOverview.PerformLayout();
            pnlThreatDistribution.ResumeLayout(false);
            pnlThreatDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlScanActivity.ResumeLayout(false);
            pnlScanActivity.PerformLayout();
            pnlRecentScans.ResumeLayout(false);
            pnlRecentScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentScans).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlQuickScan.ResumeLayout(false);
            pnlQuickScan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSidebarTitle;
        private Label lblSidebarShield;
        private Button btnDashboard;
        private Button btnURLScanner;
        private Button btnEmailScanner;
        private Button btnHistory;
        private Button btnFileScanner;
        private Button btnPasswordAnalyzer;
        private Button btnSettings;
        private Button btnReports;
        private Button btnLogout;
        private Label lblWelcome;
        private Label lblDashboardSubtitle;
        private Panel pnlTotalScans;
        private Label lblTotalScansTitle;
        private Label lblTotalScansValue;
        private Panel pnlThreats;
        private Label lblThreatsValue;
        private Label lblThreatsTitle;
        private Panel pnlSafeURLs;
        private Label lblSafeURLsValue;
        private Label lblSafeURLsTitle;
        private Panel pnlRiskScore;
        private Label lblRiskScoreValue;
        private Label lblRiskScoreTitle;
        private Label lblUserName;
        private PictureBox picTotalScans;
        private PictureBox picThreats;
        private PictureBox picSafeURLs;
        private PictureBox picRiskScore;
        private PictureBox picUser;
        private Label lblProfileName;
        private Label lblProfileArrow;
        private Panel pnlProfile;
        private Panel pnlUserInfo;
        private Label lblProfileTitle;
        private Label label8;
        private Label lblProfilePassword;
        private Label label6;
        private Label lblProfileEmail;
        private Label lblUsernameValue;
        private Label lblProfileUsername;
        private Label lblFullNameValue;
        private Label lblProfileFullName;
        private TextBox txtProfileFullName;
        private TextBox txtProfileUsername;
        private TextBox txtProfileEmail;
        private TextBox txtProfilePassword;
        private Button btnSaveProfile;
        private Button btnCancelProfile;
        private TextBox txtConfirmNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private Panel pnlSecurityOverview;
        private Label lblSecurityOverview;
        private Panel pnlScanActivity;
        private Label lblScanActivity;
        private PictureBox pictureBox1;
        private Label lblScanActivityData;
        private Panel pnlThreatDistribution;
        private Label lblThreatDistribution;
        private Label lblSuspiciousCount;
        private Label lblSafeCount;
        private Label lblThreatCount;
        private Panel pnlRecentScans;
        private Label lblRecentScansTitle;
        private DataGridView dgvRecentScans;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colScanTarget;
        private DataGridViewTextBoxColumn colScanType;
        private DataGridViewTextBoxColumn colScanResult;
        private DataGridViewTextBoxColumn colScanDate;
        private Panel pnlQuickScan;
        private Label lblQuickScanTitle;
        private Button btnQuickScan;
        private TextBox txtQuickScanUrl;
    }
}