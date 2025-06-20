namespace UnicomTIC_SchoolMnagement.Views
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Button btnStudents;
        private Button btnCourses;
        private Button btnExams;
        private Button btnMarks;
        private Button btnTimetables;
        private Button btnUsers;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnStudents = new Button();
            btnCourses = new Button();
            btnExams = new Button();
            btnMarks = new Button();
            btnTimetables = new Button();
            btnUsers = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(114, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome, Admin!";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(114, 64);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(150, 30);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Manage Students";
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(114, 100);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(150, 30);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Manage Courses";
            btnCourses.Click += btnCourses_Click;
            // 
            // btnExams
            // 
            btnExams.Location = new Point(114, 136);
            btnExams.Name = "btnExams";
            btnExams.Size = new Size(150, 30);
            btnExams.TabIndex = 3;
            btnExams.Text = "Manage Exams";
            btnExams.Click += btnExams_Click;
            // 
            // btnMarks
            // 
            btnMarks.Location = new Point(114, 172);
            btnMarks.Name = "btnMarks";
            btnMarks.Size = new Size(150, 30);
            btnMarks.TabIndex = 4;
            btnMarks.Text = "Manage Marks";
            btnMarks.Click += btnMarks_Click;
            // 
            // btnTimetables
            // 
            btnTimetables.Location = new Point(114, 208);
            btnTimetables.Name = "btnTimetables";
            btnTimetables.Size = new Size(150, 30);
            btnTimetables.TabIndex = 5;
            btnTimetables.Text = "Manage Timetables";
            btnTimetables.Click += btnTimetables_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(114, 244);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(150, 30);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "Manage Users";
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(114, 280);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboardForm
            // 
            ClientSize = new Size(383, 343);
            Controls.Add(lblTitle);
            Controls.Add(btnStudents);
            Controls.Add(btnCourses);
            Controls.Add(btnExams);
            Controls.Add(btnMarks);
            Controls.Add(btnTimetables);
            Controls.Add(btnUsers);
            Controls.Add(btnLogout);
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
        }
    }
}
