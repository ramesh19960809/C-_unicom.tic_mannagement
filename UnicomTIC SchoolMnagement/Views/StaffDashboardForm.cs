using System;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class StaffDashboardForm : Form
    {
        public StaffDashboardForm()
        {
            InitializeComponent();
        }

        private void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome, Staff!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            MessageBox.Show($"Searching for: {keyword}");
            // Search logic here (optional)
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Courses clicked");
            // Open CourseForm logic here
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Subjects clicked");
            // Open SubjectForm logic here
        }

        private void btnManageTimetables_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Timetables clicked");
            // Open TimetableForm logic here
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Or redirect to LoginForm
            }
        }
    }
}
