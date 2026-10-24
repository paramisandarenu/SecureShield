namespace SecureShield
{
    partial class URLScannerForm
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
            lblURLScannerTitle = new Label();
            lblURLScannerDescription = new Label();
            pnlURLInput = new Panel();
            lblEnterURL = new Label();
            txtURL = new TextBox();
            btnScanURL = new Button();
            pnlURLInput.SuspendLayout();
            SuspendLayout();
            // 
            // lblURLScannerTitle
            // 
            lblURLScannerTitle.AutoSize = true;
            lblURLScannerTitle.BackColor = Color.Transparent;
            lblURLScannerTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblURLScannerTitle.Location = new Point(30, 25);
            lblURLScannerTitle.Name = "lblURLScannerTitle";
            lblURLScannerTitle.Size = new Size(363, 50);
            lblURLScannerTitle.TabIndex = 0;
            lblURLScannerTitle.Text = "URL Threat Scanner";
            // 
            // lblURLScannerDescription
            // 
            lblURLScannerDescription.AutoSize = true;
            lblURLScannerDescription.BackColor = Color.Transparent;
            lblURLScannerDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblURLScannerDescription.ForeColor = Color.FromArgb(156, 163, 175);
            lblURLScannerDescription.Location = new Point(33, 75);
            lblURLScannerDescription.Name = "lblURLScannerDescription";
            lblURLScannerDescription.Size = new Size(561, 23);
            lblURLScannerDescription.TabIndex = 1;
            lblURLScannerDescription.Text = "Check a website URL for suspicious patterns and potential phishing risks.";
            // 
            // pnlURLInput
            // 
            pnlURLInput.BackColor = Color.FromArgb(31, 41, 55);
            pnlURLInput.BorderStyle = BorderStyle.FixedSingle;
            pnlURLInput.Controls.Add(btnScanURL);
            pnlURLInput.Controls.Add(txtURL);
            pnlURLInput.Controls.Add(lblEnterURL);
            pnlURLInput.Location = new Point(30, 125);
            pnlURLInput.Name = "pnlURLInput";
            pnlURLInput.Size = new Size(900, 110);
            pnlURLInput.TabIndex = 2;
            // 
            // lblEnterURL
            // 
            lblEnterURL.AutoSize = true;
            lblEnterURL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterURL.Location = new Point(20, 15);
            lblEnterURL.Name = "lblEnterURL";
            lblEnterURL.Size = new Size(166, 25);
            lblEnterURL.TabIndex = 0;
            lblEnterURL.Text = "Enter website URL";
            // 
            // txtURL
            // 
            txtURL.BackColor = Color.FromArgb(249, 250, 251);
            txtURL.ForeColor = Color.FromArgb(17, 24, 39);
            txtURL.Location = new Point(20, 50);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.PlaceholderText = "https://example.com";
            txtURL.Size = new Size(650, 35);
            txtURL.TabIndex = 1;
            // 
            // btnScanURL
            // 
            btnScanURL.BackColor = Color.FromArgb(37, 99, 235);
            btnScanURL.Cursor = Cursors.Hand;
            btnScanURL.FlatAppearance.BorderSize = 0;
            btnScanURL.FlatStyle = FlatStyle.Flat;
            btnScanURL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanURL.ForeColor = Color.White;
            btnScanURL.Location = new Point(700, 48);
            btnScanURL.Name = "btnScanURL";
            btnScanURL.Size = new Size(160, 40);
            btnScanURL.TabIndex = 2;
            btnScanURL.Text = "Scan URL";
            btnScanURL.UseVisualStyleBackColor = false;
            // 
            // URLScannerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(982, 653);
            Controls.Add(pnlURLInput);
            Controls.Add(lblURLScannerDescription);
            Controls.Add(lblURLScannerTitle);
            ForeColor = Color.FromArgb(249, 250, 251);
            Name = "URLScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - URL Scanner";
            pnlURLInput.ResumeLayout(false);
            pnlURLInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblURLScannerTitle;
        private Label lblURLScannerDescription;
        private Panel pnlURLInput;
        private TextBox txtURL;
        private Label lblEnterURL;
        private Button btnScanURL;
    }
}