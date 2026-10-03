using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureShield
{
    public partial class DashboardForm : Form
    {

        private string loggedInUsername;
        private int userID;

        public DashboardForm(string userName)
        {
            InitializeComponent();
            pnlUserInfo.Visible = false;

            loggedInUsername = userName;


            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT UserID, FullName, Username, Email, CreatedAt
                FROM Users
                WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", loggedInUsername);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = Convert.ToInt32(reader["UserID"]);

                                string fullName = reader["FullName"].ToString();
                                string username = reader["Username"].ToString();
                                string email = reader["Email"].ToString();

                                // Dashboard welcome message
                                lblUserName.Text = fullName;

                                // Top-right profile
                                lblProfileName.Text = fullName;

                                // Profile fields
                                txtProfileFullName.Text = fullName;
                                txtProfileUsername.Text = username;
                                txtProfileEmail.Text = email;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load profile information.\n\n" + ex.Message,
                    "SecureShield",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {
            pnlUserInfo.Visible = !pnlUserInfo.Visible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string fullName = txtProfileFullName.Text.Trim();
            string username = txtProfileUsername.Text.Trim();
            string email = txtProfileEmail.Text.Trim();

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtProfilePassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "SecureShield",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Check whether the user is trying to change the password
            bool changingPassword =
                !string.IsNullOrWhiteSpace(currentPassword) ||
                !string.IsNullOrWhiteSpace(newPassword) ||
                !string.IsNullOrWhiteSpace(confirmPassword);

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Password change validation
                    if (changingPassword)
                    {
                        if (string.IsNullOrWhiteSpace(currentPassword) ||
                            string.IsNullOrWhiteSpace(newPassword) ||
                            string.IsNullOrWhiteSpace(confirmPassword))
                        {
                            MessageBox.Show(
                                "Please complete all password fields.",
                                "SecureShield",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            return;
                        }

                        if (newPassword != confirmPassword)
                        {
                            MessageBox.Show(
                                "New password and confirmation password do not match.",
                                "SecureShield",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            return;
                        }

                        string passwordQuery = @"
                    SELECT PasswordHash
                    FROM Users
                    WHERE UserID = @UserID";

                        using (SqlCommand passwordCommand =
                               new SqlCommand(passwordQuery, connection))
                        {
                            passwordCommand.Parameters.AddWithValue(
                                "@UserID", userID);

                            object result = passwordCommand.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show(
                                    "User account could not be found.",
                                    "SecureShield",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                return;
                            }

                            string storedHash = result.ToString();

                            if (!PasswordHasher.VerifyPassword(
                                    currentPassword, storedHash))
                            {
                                MessageBox.Show(
                                    "Current password is incorrect.",
                                    "SecureShield",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                return;
                            }
                        }
                    }

                    string query;

                    if (changingPassword)
                    {
                        query = @"
                    UPDATE Users
                    SET FullName = @FullName,
                        Username = @Username,
                        Email = @Email,
                        PasswordHash = @PasswordHash
                    WHERE UserID = @UserID";
                    }
                    else
                    {
                        query = @"
                    UPDATE Users
                    SET FullName = @FullName,
                        Username = @Username,
                        Email = @Email
                    WHERE UserID = @UserID";
                    }

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@UserID", userID);

                        if (changingPassword)
                        {
                            string hashedPassword =
                                PasswordHasher.HashPassword(newPassword);

                            command.Parameters.AddWithValue(
                                "@PasswordHash",
                                hashedPassword);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                loggedInUsername = username;

                lblUserName.Text = fullName;
                lblProfileName.Text = fullName;

                txtCurrentPassword.Clear();
                txtProfilePassword.Clear();
                txtConfirmNewPassword.Clear();

                MessageBox.Show(
                    "Profile updated successfully!",
                    "SecureShield",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pnlUserInfo.Visible = false;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Username or email already exists.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update profile.\n\n" + ex.Message,
                    "SecureShield",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelProfile_Click(object sender, EventArgs e)
        {
            LoadUserProfile();

            txtProfilePassword.Clear();

            pnlUserInfo.Visible = false;
        }
    }
}
