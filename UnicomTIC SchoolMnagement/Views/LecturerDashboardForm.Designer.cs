namespace UnicomTICManagementSystem.Views
{
    partial class LecturerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnViewMarks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvLecturerData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblSearch = new Label();
            txtSearchStudent = new TextBox();
            btnSearch = new Button();
            btnViewCourses = new Button();
            btnAddMark = new Button();
            btnViewMarks = new Button();
            btnLogout = new Button();
            dgvLecturerData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLecturerData).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(183, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Lecturer!";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 70);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Student:";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(130, 65);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(200, 23);
            txtSearchStudent.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(340, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewCourses
            // 
            btnViewCourses.Location = new Point(20, 110);
            btnViewCourses.Name = "btnViewCourses";
            btnViewCourses.Size = new Size(120, 30);
            btnViewCourses.TabIndex = 4;
            btnViewCourses.Text = "View My Courses";
            btnViewCourses.UseVisualStyleBackColor = true;
            btnViewCourses.Click += btnViewCourses_Click;
            // 
            // btnAddMark
            // 
            btnAddMark.Location = new Point(198, 110);
            btnAddMark.Name = "btnAddMark";
            btnAddMark.Size = new Size(100, 30);
            btnAddMark.TabIndex = 5;
            btnAddMark.Text = "Add Marks";
            btnAddMark.UseVisualStyleBackColor = true;
            btnAddMark.Click += btnAddMark_Click;
            // 
            // btnViewMarks
            // 
            btnViewMarks.Location = new Point(360, 110);
            btnViewMarks.Name = "btnViewMarks";
            btnViewMarks.Size = new Size(100, 30);
            btnViewMarks.TabIndex = 6;
            btnViewMarks.Text = "View Marks";
            btnViewMarks.UseVisualStyleBackColor = true;
            btnViewMarks.Click += btnViewMarks_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(506, 110);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvLecturerData
            // 
            dgvLecturerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLecturerData.Location = new Point(20, 160);
            dgvLecturerData.Name = "dgvLecturerData";
            dgvLecturerData.Size = new Size(600, 250);
            dgvLecturerData.TabIndex = 8;
            // 
            // LecturerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 440);
            Controls.Add(lblWelcome);
            Controls.Add(lblSearch);
            Controls.Add(txtSearchStudent);
            Controls.Add(btnSearch);
            Controls.Add(btnViewCourses);
            Controls.Add(btnAddMark);
            Controls.Add(btnViewMarks);
            Controls.Add(btnLogout);
            Controls.Add(dgvLecturerData);
            Name = "LecturerDashboardForm";
            Text = "Lecturer Dashboard";
            Load += LecturerDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLecturerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
