namespace SecureShield
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblShield = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            lblLogin = new Label();
            lblFooter = new Label();
            btnShowPassword = new Button();
            btnShowConfirmPassword = new Button();
            SuspendLayout();
            // 
            // lblShield
            // 
            lblShield.AutoSize = true;
            lblShield.BackColor = Color.Transparent;
            lblShield.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShield.ForeColor = Color.FromArgb(37, 99, 235);
            lblShield.Location = new Point(435, -6);
            lblShield.Name = "lblShield";
            lblShield.Size = new Size(116, 80);
            lblShield.TabIndex = 0;
            lblShield.Text = "🛡";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(249, 250, 251);
            lblTitle.Location = new Point(336, 74);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SecureShield";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitle.Location = new Point(405, 136);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(172, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create Your Account";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(249, 250, 251);
            lblFullName.Location = new Point(336, 184);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 23);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(336, 210);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 39);
            txtFullName.TabIndex = 4;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(249, 250, 251);
            lblUsername.Location = new Point(336, 268);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(336, 294);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 39);
            txtUsername.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(249, 250, 251);
            lblEmail.Location = new Point(336, 353);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(336, 379);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 39);
            txtEmail.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(249, 250, 251);
            lblPassword.Location = new Point(336, 444);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(336, 470);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(350, 27);
            txtPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(249, 250, 251);
            lblConfirmPassword.Location = new Point(336, 536);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(146, 23);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(336, 562);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(350, 27);
            txtConfirmPassword.TabIndex = 12;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(37, 99, 235);
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.FromArgb(249, 250, 251);
            btnCreateAccount.Location = new Point(390, 633);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(234, 36);
            btnCreateAccount.TabIndex = 13;
            btnCreateAccount.Text = "CREATE ACCOUNT";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(37, 99, 235);
            lblLogin.Location = new Point(390, 681);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(219, 20);
            lblLogin.TabIndex = 14;
            lblLogin.Text = "Already have an account? Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(426, 710);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(161, 20);
            lblFooter.TabIndex = 15;
            lblFooter.Text = "Secure. Detect. Protect.";
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.FromArgb(17, 24, 39);
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.ForeColor = Color.FromArgb(148, 163, 184);
            btnShowPassword.Location = new Point(706, 468);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(35, 30);
            btnShowPassword.TabIndex = 16;
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnShowConfirmPassword
            // 
            btnShowConfirmPassword.BackColor = Color.FromArgb(17, 24, 39);
            btnShowConfirmPassword.FlatAppearance.BorderSize = 0;
            btnShowConfirmPassword.FlatStyle = FlatStyle.Flat;
            btnShowConfirmPassword.ForeColor = Color.FromArgb(148, 163, 184);
            btnShowConfirmPassword.Location = new Point(706, 559);
            btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            btnShowConfirmPassword.Size = new Size(35, 30);
            btnShowConfirmPassword.TabIndex = 17;
            btnShowConfirmPassword.UseVisualStyleBackColor = false;
            btnShowConfirmPassword.Click += btnShowConfirmPassword_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 17, 32);
            ClientSize = new Size(982, 752);
            Controls.Add(btnShowConfirmPassword);
            Controls.Add(btnShowPassword);
            Controls.Add(lblFooter);
            Controls.Add(lblLogin);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(lblShield);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShield;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnCreateAccount;
        private Label lblLogin;
        private Label lblFooter;
        private Button btnShowPassword;
        private Button btnShowConfirmPassword;
    }
}
