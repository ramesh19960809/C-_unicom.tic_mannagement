using System;
using System.Data.SQLite;
using System.Windows.Forms;
using UnicomTIC_SchoolMnagement.Views;
using UnicomTICManagementSystem.Repositories; // For DatabaseManager
using UnicomTICManagementSystem.Views;

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
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Unicom.db;Version=3;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                Form dashboardForm = null;

                                if (role == "Admin")
                                    dashboardForm = new AdminDashboardForm();
                                else if (role == "Lecturer")
                                    dashboardForm = new LecturerDashboardForm();
                                else
                                {
                                    MessageBox.Show("Unauthorized user.");
                                    return;
                                }

                                MessageBox.Show("Login successful.");
                                dashboardForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}
