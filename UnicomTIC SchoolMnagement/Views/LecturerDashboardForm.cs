using System;
using System.Windows.Forms;
using UnicomTIC_SchoolMnagement.Views;

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
            MessageBox.Show($"Searching for: {keyword}");
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();
            MessageBox.Show("View Courses clicked");
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.Show();
            this.Hide();
            MessageBox.Show("Add Mark clicked");
        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.Show();
            this.Hide();
            MessageBox.Show("View Marks clicked");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}
