namespace UnicomTICManagementSystem.Views
{
    partial class StudentDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnViewCourses;
        private Button btnViewTimetable;
        private Button btnViewMarks;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnViewTimetable = new System.Windows.Forms.Button();
            this.btnViewMarks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(120, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 32);
            this.lblWelcome.Text = "Welcome, Student!";

            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(120, 90);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(200, 40);
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);

            // 
            // btnViewTimetable
            // 
            this.btnViewTimetable.Location = new System.Drawing.Point(120, 140);
            this.btnViewTimetable.Name = "btnViewTimetable";
            this.btnViewTimetable.Size = new System.Drawing.Size(200, 40);
            this.btnViewTimetable.Text = "View Timetable";
            this.btnViewTimetable.Click += new System.EventHandler(this.btnViewTimetable_Click);

            // 
            // btnViewMarks
            // 
            this.btnViewMarks.Location = new System.Drawing.Point(120, 190);
            this.btnViewMarks.Name = "btnViewMarks";
            this.btnViewMarks.Size = new System.Drawing.Size(200, 40);
            this.btnViewMarks.Text = "View Marks";
            this.btnViewMarks.Click += new System.EventHandler(this.btnViewMarks_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(120, 250);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // StudentDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnViewCourses);
            this.Controls.Add(this.btnViewTimetable);
            this.Controls.Add(this.btnViewMarks);
            this.Controls.Add(this.btnLogout);
            this.Name = "StudentDashboardForm";
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
        }
    }
}
