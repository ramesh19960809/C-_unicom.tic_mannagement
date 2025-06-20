using System;
using System.Data.SQLite;
using System.Windows.Forms;
using UnicomTIC_SchoolMnagement.Views; // ✅ Correct namespace for dashboard forms

namespace UnicomTICManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide password
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=teachers.db;Version=3;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successful!");

                            string role = reader["Role"].ToString();

                            if (role == "Admin")
                            {
                                AdminDashboardForm adminForm = new AdminDashboardForm();
                                adminForm.Show();
                            }
                            else if (role == "Lecturer")
                            {
                                LecturerDashboardForm lecturerForm = new LecturerDashboardForm();
                                lecturerForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("You are not authorized.");
                                return;
                            }

                            this.Hide(); // hide login form after successful login
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }
    }
}
