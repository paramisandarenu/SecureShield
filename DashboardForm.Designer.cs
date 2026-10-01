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
            pnlScans = new Panel();
            lblScansValue = new Label();
            lblScansTitle = new Label();
            pnlThreats = new Panel();
            lblThreatsValue = new Label();
            lblThreatsTitle = new Label();
            pnlSafeURLs = new Panel();
            lblSafeURLsValue = new Label();
            lblSafeURLsTitle = new Label();
            pnlRiskScore = new Panel();
            lblRiskScoreValue = new Label();
            lblRiskScoreTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlScans.SuspendLayout();
            pnlThreats.SuspendLayout();
            pnlSafeURLs.SuspendLayout();
            pnlRiskScore.SuspendLayout();
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
            lblWelcome.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(249, 250, 251);
            lblWelcome.Location = new Point(432, 29);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(552, 60);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to SecureShield";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblDashboardSubtitle.Location = new Point(543, 101);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(332, 25);
            lblDashboardSubtitle.TabIndex = 2;
            lblDashboardSubtitle.Text = "Monitor and analyze your security status";
            // 
            // pnlScans
            // 
            pnlScans.BackColor = Color.FromArgb(31, 41, 55);
            pnlScans.Controls.Add(lblScansValue);
            pnlScans.Controls.Add(lblScansTitle);
            pnlScans.Location = new Point(443, 214);
            pnlScans.Name = "pnlScans";
            pnlScans.Size = new Size(190, 120);
            pnlScans.TabIndex = 3;
            // 
            // lblScansValue
            // 
            lblScansValue.AutoSize = true;
            lblScansValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScansValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblScansValue.Location = new Point(64, 45);
            lblScansValue.Name = "lblScansValue";
            lblScansValue.Size = new Size(50, 60);
            lblScansValue.TabIndex = 1;
            lblScansValue.Text = "0";
            // 
            // lblScansTitle
            // 
            lblScansTitle.AutoSize = true;
            lblScansTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScansTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblScansTitle.Location = new Point(42, 12);
            lblScansTitle.Name = "lblScansTitle";
            lblScansTitle.Size = new Size(94, 23);
            lblScansTitle.TabIndex = 0;
            lblScansTitle.Text = "Total Scans";
            // 
            // pnlThreats
            // 
            pnlThreats.BackColor = Color.FromArgb(31, 41, 55);
            pnlThreats.Controls.Add(lblThreatsValue);
            pnlThreats.Controls.Add(lblThreatsTitle);
            pnlThreats.Location = new Point(807, 214);
            pnlThreats.Name = "pnlThreats";
            pnlThreats.Size = new Size(190, 120);
            pnlThreats.TabIndex = 4;
            // 
            // lblThreatsValue
            // 
            lblThreatsValue.AutoSize = true;
            lblThreatsValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThreatsValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblThreatsValue.Location = new Point(64, 45);
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
            lblThreatsTitle.Location = new Point(28, 12);
            lblThreatsTitle.Name = "lblThreatsTitle";
            lblThreatsTitle.Size = new Size(140, 23);
            lblThreatsTitle.TabIndex = 0;
            lblThreatsTitle.Text = "Threats Detected";
            // 
            // pnlSafeURLs
            // 
            pnlSafeURLs.BackColor = Color.FromArgb(31, 41, 55);
            pnlSafeURLs.Controls.Add(lblSafeURLsValue);
            pnlSafeURLs.Controls.Add(lblSafeURLsTitle);
            pnlSafeURLs.Location = new Point(443, 493);
            pnlSafeURLs.Name = "pnlSafeURLs";
            pnlSafeURLs.Size = new Size(190, 120);
            pnlSafeURLs.TabIndex = 5;
            // 
            // lblSafeURLsValue
            // 
            lblSafeURLsValue.AutoSize = true;
            lblSafeURLsValue.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSafeURLsValue.ForeColor = Color.FromArgb(249, 250, 251);
            lblSafeURLsValue.Location = new Point(64, 45);
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
            lblSafeURLsTitle.Location = new Point(52, 12);
            lblSafeURLsTitle.Name = "lblSafeURLsTitle";
            lblSafeURLsTitle.Size = new Size(84, 23);
            lblSafeURLsTitle.TabIndex = 0;
            lblSafeURLsTitle.Text = "Safe URLs";
            // 
            // pnlRiskScore
            // 
            pnlRiskScore.BackColor = Color.FromArgb(31, 41, 55);
            pnlRiskScore.Controls.Add(lblRiskScoreValue);
            pnlRiskScore.Controls.Add(lblRiskScoreTitle);
            pnlRiskScore.Location = new Point(807, 493);
            pnlRiskScore.Name = "pnlRiskScore";
            pnlRiskScore.Size = new Size(190, 120);
            pnlRiskScore.TabIndex = 6;
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
            lblRiskScoreTitle.Location = new Point(42, 12);
            lblRiskScoreTitle.Name = "lblRiskScoreTitle";
            lblRiskScoreTitle.Size = new Size(117, 23);
            lblRiskScoreTitle.TabIndex = 0;
            lblRiskScoreTitle.Text = "Security Score";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 17, 32);
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlRiskScore);
            Controls.Add(pnlSafeURLs);
            Controls.Add(pnlThreats);
            Controls.Add(pnlScans);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlScans.ResumeLayout(false);
            pnlScans.PerformLayout();
            pnlThreats.ResumeLayout(false);
            pnlThreats.PerformLayout();
            pnlSafeURLs.ResumeLayout(false);
            pnlSafeURLs.PerformLayout();
            pnlRiskScore.ResumeLayout(false);
            pnlRiskScore.PerformLayout();
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
        private Panel pnlScans;
        private Label lblScansTitle;
        private Label lblScansValue;
        private Panel pnlThreats;
        private Label lblThreatsValue;
        private Label lblThreatsTitle;
        private Panel pnlSafeURLs;
        private Label lblSafeURLsValue;
        private Label lblSafeURLsTitle;
        private Panel pnlRiskScore;
        private Label lblRiskScoreValue;
        private Label lblRiskScoreTitle;
    }
}