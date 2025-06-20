using System;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class LecturerDashboardForm : Form
    {
        public LecturerDashboardForm()
        {
            InitializeComponent();
        }

        private void LecturerDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, Lecturer!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchStudent.Text.Trim();
            // Search logic to be implemented
            MessageBox.Show($"Searching for: {keyword}");
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            // View courses logic
            MessageBox.Show("View Courses clicked");
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            // Add marks logic
            MessageBox.Show("Add Mark clicked");
        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            // View marks logic
            MessageBox.Show("View Marks clicked");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Or go to LoginForm
            }
        }
    }
}
