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
            pnlUserInfo = new Panel();
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
            lblCurrentPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            pnlSidebar.SuspendLayout();
            pnlTotalScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalScans).BeginInit();
            pnlThreats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThreats).BeginInit();
            pnlSafeURLs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSafeURLs).BeginInit();
            pnlRiskScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRiskScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlUserInfo.SuspendLayout();
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
            pnlSidebar.Location = new Point(3, 12);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 690);
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
            btnLogout.Location = new Point(10, 595);
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
            lblWelcome.Location = new Point(270, 25);
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
            lblDashboardSubtitle.Location = new Point(270, 77);
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
            pnlTotalScans.Location = new Point(270, 165);
            pnlTotalScans.Name = "pnlTotalScans";
            pnlTotalScans.Size = new Size(190, 120);
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
            lblTotalScansValue.Location = new Point(66, 45);
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
            pnlThreats.Location = new Point(501, 165);
            pnlThreats.Name = "pnlThreats";
            pnlThreats.Size = new Size(190, 120);
            pnlThreats.TabIndex = 4;
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
            lblThreatsValue.Location = new Point(67, 45);
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
            pnlSafeURLs.Location = new Point(732, 165);
            pnlSafeURLs.Name = "pnlSafeURLs";
            pnlSafeURLs.Size = new Size(190, 120);
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
            lblSafeURLsValue.Location = new Point(76, 45);
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
            pnlRiskScore.Location = new Point(959, 163);
            pnlRiskScore.Name = "pnlRiskScore";
            pnlRiskScore.Size = new Size(190, 120);
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
            lblRiskScoreValue.Location = new Point(30, 45);
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
            lblUserName.Location = new Point(501, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 41);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "User";
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(955, 35);
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
            lblProfileName.Location = new Point(989, 38);
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
            lblProfileArrow.Location = new Point(1151, 44);
            lblProfileArrow.Name = "lblProfileArrow";
            lblProfileArrow.Size = new Size(19, 17);
            lblProfileArrow.TabIndex = 10;
            lblProfileArrow.Text = "▼";
            lblProfileArrow.Click += pnlProfile_Click;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Transparent;
            pnlProfile.Location = new Point(608, 88);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(77, 61);
            pnlProfile.TabIndex = 11;
            pnlProfile.Visible = false;
            pnlProfile.Click += pnlProfile_Click;
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
            pnlUserInfo.Location = new Point(870, 88);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(300, 564);
            pnlUserInfo.TabIndex = 12;
            pnlUserInfo.Visible = false;
            // 
            // btnCancelProfile
            // 
            btnCancelProfile.BackColor = Color.FromArgb(55, 65, 81);
            btnCancelProfile.FlatAppearance.BorderSize = 0;
            btnCancelProfile.FlatStyle = FlatStyle.Flat;
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
            lblProfileTitle.Location = new Point(14, 11);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(165, 31);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "👤 My Profile";
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 17, 32);
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlUserInfo);
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
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlTotalScans.ResumeLayout(false);
            pnlTotalScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalScans).EndInit();
            pnlThreats.ResumeLayout(false);
            pnlThreats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picThreats).EndInit();
            pnlSafeURLs.ResumeLayout(false);
            pnlSafeURLs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSafeURLs).EndInit();
            pnlRiskScore.ResumeLayout(false);
            pnlRiskScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRiskScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
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
    }
}