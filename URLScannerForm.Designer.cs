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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLScannerForm));
            lblPageTitle = new Label();
            lblDescription = new Label();
            pnlURLInput = new Panel();
            lblEnterURL = new Label();
            txtURL = new TextBox();
            btnScanURL = new Button();
            picShield = new PictureBox();
            picLink = new PictureBox();
            pnlURLInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLink).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(85, 30);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(391, 50);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "URL Security Scanner";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(156, 163, 175);
            lblDescription.Location = new Point(87, 78);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(526, 23);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Analyze URLs for suspicious patterns and potential phishing threats.";
            // 
            // pnlURLInput
            // 
            pnlURLInput.BackColor = Color.FromArgb(31, 41, 55);
            pnlURLInput.BorderStyle = BorderStyle.FixedSingle;
            pnlURLInput.Controls.Add(picLink);
            pnlURLInput.Controls.Add(btnScanURL);
            pnlURLInput.Controls.Add(txtURL);
            pnlURLInput.Controls.Add(lblEnterURL);
            pnlURLInput.Location = new Point(30, 135);
            pnlURLInput.Name = "pnlURLInput";
            pnlURLInput.Size = new Size(920, 155);
            pnlURLInput.TabIndex = 2;
            // 
            // lblEnterURL
            // 
            lblEnterURL.AutoSize = true;
            lblEnterURL.BackColor = Color.Transparent;
            lblEnterURL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterURL.Location = new Point(55, 18);
            lblEnterURL.Name = "lblEnterURL";
            lblEnterURL.Size = new Size(189, 25);
            lblEnterURL.TabIndex = 0;
            lblEnterURL.Text = "Enter URL to analyze";
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
            // picShield
            // 
            picShield.BackColor = Color.Transparent;
            picShield.Image = (Image)resources.GetObject("picShield.Image");
            picShield.Location = new Point(21, 41);
            picShield.Name = "picShield";
            picShield.Size = new Size(60, 60);
            picShield.SizeMode = PictureBoxSizeMode.Zoom;
            picShield.TabIndex = 3;
            picShield.TabStop = false;
            // 
            // picLink
            // 
            picLink.BackColor = Color.Transparent;
            picLink.Image = (Image)resources.GetObject("picLink.Image");
            picLink.Location = new Point(20, 17);
            picLink.Name = "picLink";
            picLink.Size = new Size(25, 25);
            picLink.SizeMode = PictureBoxSizeMode.Zoom;
            picLink.TabIndex = 3;
            picLink.TabStop = false;
            // 
            // URLScannerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(982, 703);
            Controls.Add(picShield);
            Controls.Add(pnlURLInput);
            Controls.Add(lblDescription);
            Controls.Add(lblPageTitle);
            ForeColor = Color.FromArgb(249, 250, 251);
            Name = "URLScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureShield - URL Scanner";
            pnlURLInput.ResumeLayout(false);
            pnlURLInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShield).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblDescription;
        private Panel pnlURLInput;
        private TextBox txtURL;
        private Label lblEnterURL;
        private Button btnScanURL;
        private PictureBox picShield;
        private PictureBox picLink;
    }
}