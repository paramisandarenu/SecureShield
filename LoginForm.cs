using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SecureShield
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Password hidden by default
            txtPassword.PasswordChar = '●';
            txtPassword.UseSystemPasswordChar = false;

            // Eye button
            btnShowPassword.Text = "";
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.BackColor = Color.FromArgb(17, 24, 39);

            btnShowPassword.Image = Image.FromFile(
                Path.Combine(
                    Application.StartupPath,
                    "Resources",
                    "visibility_off.png"
                )
            );

            btnShowPassword.ImageAlign =
                ContentAlignment.MiddleCenter;
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
        }

        // Show / Hide Password
        private void btnShowPassword_Click(object sender, EventArgs e)
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

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login",
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
                        SELECT PasswordHash
                        FROM Users
                        WHERE Username = @Username";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Username",
                            username
                        );

                        object result =
                            command.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHash =
                                result.ToString();

                            bool passwordCorrect =
                                PasswordHasher.VerifyPassword(
                                    password,
                                    storedHash
                                );

                            if (passwordCorrect)
                            {
                                MessageBox.Show(
                                    "Login successful!",
                                    "SecureShield",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                DashboardForm dashboardForm =
                                    new DashboardForm(username);

                                dashboardForm.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid username or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Go to Registration
        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm =
                new RegistrationForm();

            registrationForm.Show();

            this.Hide();
        }
    }
}