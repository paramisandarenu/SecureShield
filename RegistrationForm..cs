using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SecureShield
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            // Password hidden by default
            txtPassword.PasswordChar = '●';
            txtPassword.UseSystemPasswordChar = false;

            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.UseSystemPasswordChar = false;

            // Eye buttons
            btnShowPassword.Text = "";
            btnShowConfirmPassword.Text = "";

            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.BackColor =
                Color.FromArgb(17, 24, 39);

            btnShowConfirmPassword.FlatStyle = FlatStyle.Flat;
            btnShowConfirmPassword.FlatAppearance.BorderSize = 0;
            btnShowConfirmPassword.BackColor =
                Color.FromArgb(17, 24, 39);

            // Hidden eye icon
            btnShowPassword.Image = Image.FromFile(
                Path.Combine(
                    Application.StartupPath,
                    "Resources",
                    "visibility_off.png"
                )
            );

            btnShowConfirmPassword.Image = Image.FromFile(
                Path.Combine(
                    Application.StartupPath,
                    "Resources",
                    "visibility_off.png"
                )
            );

            btnShowPassword.ImageAlign =
                ContentAlignment.MiddleCenter;

            btnShowConfirmPassword.ImageAlign =
                ContentAlignment.MiddleCenter;
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }

        private void txtFullName_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        // Show / Hide Password
        private void btnShowPassword_Click(
            object sender,
            EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                // Show password
                txtPassword.PasswordChar = '\0';

                btnShowPassword.Image = Image.FromFile(
                    Path.Combine(
                        Application.StartupPath,
                        "Resources",
                        "visibility.png"
                    )
                );
            }
            else
            {
                // Hide password
                txtPassword.PasswordChar = '●';

                btnShowPassword.Image = Image.FromFile(
                    Path.Combine(
                        Application.StartupPath,
                        "Resources",
                        "visibility_off.png"
                    )
                );
            }
        }

        // Show / Hide Confirm Password
        private void btnShowConfirmPassword_Click(
            object sender,
            EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '●')
            {
                // Show confirm password
                txtConfirmPassword.PasswordChar = '\0';

                btnShowConfirmPassword.Image =
                    Image.FromFile(
                        Path.Combine(
                            Application.StartupPath,
                            "Resources",
                            "visibility.png"
                        )
                    );
            }
            else
            {
                // Hide confirm password
                txtConfirmPassword.PasswordChar = '●';

                btnShowConfirmPassword.Image =
                    Image.FromFile(
                        Path.Combine(
                            Application.StartupPath,
                            "Resources",
                            "visibility_off.png"
                        )
                    );
            }
        }

        // Create Account
        private void btnCreateAccount_Click(
            object sender,
            EventArgs e)
        {
            string fullName =
                txtFullName.Text.Trim();

            string username =
                txtUsername.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string password =
                txtPassword.Text;

            string confirmPassword =
                txtConfirmPassword.Text;

            // Check empty fields
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Check passwords
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Users
                        (
                            FullName,
                            Username,
                            Email,
                            PasswordHash
                        )
                        VALUES
                        (
                            @FullName,
                            @Username,
                            @Email,
                            @PasswordHash
                        )";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        // Hash password before saving
                        string hashedPassword =
                            PasswordHasher.HashPassword(password);

                        command.Parameters.AddWithValue(
                            "@FullName",
                            fullName
                        );

                        command.Parameters.AddWithValue(
                            "@Username",
                            username
                        );

                        command.Parameters.AddWithValue(
                            "@Email",
                            email
                        );

                        command.Parameters.AddWithValue(
                            "@PasswordHash",
                            hashedPassword
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Account created successfully!",
                    "SecureShield",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Hide();
            }
            catch (SqlException ex)
                when (ex.Number == 2627 ||
                      ex.Number == 2601)
            {
                MessageBox.Show(
                    "Username or email already exists.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Go to Login
        private void lblLogin_Click(
            object sender,
            EventArgs e)
        {
            LoginForm loginForm =
                new LoginForm();

            loginForm.Show();

            this.Hide();
        }
    }
}