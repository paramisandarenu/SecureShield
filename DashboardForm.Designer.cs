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
            pnlSidebar = new Panel();
            lblSidebarShield = new Label();
            lblSidebarTitle = new Label();
            btnDashboard = new Button();
            btnURLScanner = new Button();
            btnEmailScanner = new Button();
            btnPasswordAnalyzer = new Button();
            btnFileScanner = new Button();
            btnHistory = new Button();
            btnReports = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            pnlSidebar.SuspendLayout();
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
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(37, 99, 235);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(249, 250, 251);
            btnDashboard.Location = new Point(12, 153);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnURLScanner
            // 
            btnURLScanner.FlatAppearance.BorderSize = 0;
            btnURLScanner.FlatStyle = FlatStyle.Flat;
            btnURLScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnURLScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnURLScanner.Location = new Point(12, 226);
            btnURLScanner.Name = "btnURLScanner";
            btnURLScanner.Size = new Size(210, 45);
            btnURLScanner.TabIndex = 3;
            btnURLScanner.Text = "URL Scanner";
            btnURLScanner.UseVisualStyleBackColor = false;
            // 
            // btnEmailScanner
            // 
            btnEmailScanner.FlatAppearance.BorderSize = 0;
            btnEmailScanner.FlatStyle = FlatStyle.Flat;
            btnEmailScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmailScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnEmailScanner.Location = new Point(10, 277);
            btnEmailScanner.Name = "btnEmailScanner";
            btnEmailScanner.Size = new Size(210, 45);
            btnEmailScanner.TabIndex = 4;
            btnEmailScanner.Text = "Email Scanner";
            btnEmailScanner.UseVisualStyleBackColor = false;
            // 
            // btnPasswordAnalyzer
            // 
            btnPasswordAnalyzer.FlatAppearance.BorderSize = 0;
            btnPasswordAnalyzer.FlatStyle = FlatStyle.Flat;
            btnPasswordAnalyzer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPasswordAnalyzer.ForeColor = Color.FromArgb(249, 250, 251);
            btnPasswordAnalyzer.Location = new Point(9, 328);
            btnPasswordAnalyzer.Name = "btnPasswordAnalyzer";
            btnPasswordAnalyzer.Size = new Size(210, 45);
            btnPasswordAnalyzer.TabIndex = 5;
            btnPasswordAnalyzer.Text = "Password Analyzer";
            btnPasswordAnalyzer.UseVisualStyleBackColor = false;
            // 
            // btnFileScanner
            // 
            btnFileScanner.FlatAppearance.BorderSize = 0;
            btnFileScanner.FlatStyle = FlatStyle.Flat;
            btnFileScanner.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileScanner.ForeColor = Color.FromArgb(249, 250, 251);
            btnFileScanner.Location = new Point(9, 379);
            btnFileScanner.Name = "btnFileScanner";
            btnFileScanner.Size = new Size(210, 45);
            btnFileScanner.TabIndex = 6;
            btnFileScanner.Text = "File Scanner";
            btnFileScanner.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(249, 250, 251);
            btnHistory.Location = new Point(12, 430);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(210, 45);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "Security History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += button4_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.FromArgb(249, 250, 251);
            btnReports.Location = new Point(12, 481);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(210, 45);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(249, 250, 251);
            btnSettings.Location = new Point(12, 532);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(210, 45);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(249, 250, 251);
            btnLogout.Location = new Point(10, 595);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(210, 45);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 17, 32);
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
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
    }
}