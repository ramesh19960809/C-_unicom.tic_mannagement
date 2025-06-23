using System;
using System.Windows.Forms;
using UnicomTIC_SchoolMnagement.Views;

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
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();
            MessageBox.Show("Manage Courses clicked");
            // Open CourseForm logic here
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.Show();
            this.Hide();
            MessageBox.Show("Manage Subjects clicked");
            // Open SubjectForm logic here
        }

        private void btnManageTimetables_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            timetableForm.Show();
            this.Hide();
            MessageBox.Show("Manage Timetables clicked");
            // Open TimetableForm logic here
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide(); // Or redirect to LoginForm
            }
        }
    }
}
