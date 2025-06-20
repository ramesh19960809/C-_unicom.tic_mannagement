using System;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, Student!";
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing enrolled courses...");
        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing timetable...");
        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing marks...");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Or redirect to login form
            }
        }
    }
}
