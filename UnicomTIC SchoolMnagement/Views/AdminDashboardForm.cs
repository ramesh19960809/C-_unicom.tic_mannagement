using StudentManagementSystem;
using System;
using System.Windows.Forms;
using UnicomTICManagementSystem;
using UnicomTICManagementSystem.Views;

namespace UnicomTIC_SchoolMnagement.Views
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome, Admin!";
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentsForm();
            studentForm.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            var courseForm = new CourseForm();
            courseForm.ShowDialog();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            var examForm = new ExamForm();
            examForm.ShowDialog();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            var markForm = new MarkForm();
            markForm.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            var timeForm = new TimetableForm();
            timeForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
