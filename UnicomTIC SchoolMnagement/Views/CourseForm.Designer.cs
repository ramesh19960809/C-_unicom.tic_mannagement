namespace UnicomTICManagementSystem.Views
{
    partial class CourseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDuration = new Label();
            txtDuration = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCourses = new DataGridView();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(30, 60);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(79, 15);
            lblCourseName.TabIndex = 2;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(130, 57);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(200, 23);
            txtCourseName.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(130, 97);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 5;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(30, 140);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(105, 15);
            lblDuration.TabIndex = 6;
            lblDuration.Text = "Duration (Months)";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(130, 137);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(200, 23);
            txtDuration.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 30);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(270, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 30);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(30, 230);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.Size = new Size(500, 200);
            dgvCourses.TabIndex = 0;
            dgvCourses.CellClick += dgvCourses_CellClick;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(130, 15);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(200, 23);
            txtCourseID.TabIndex = 12;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(30, 23);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 13;
            lblCourseID.Text = "Course ID";
            // 
            // CourseForm
            // 
            ClientSize = new Size(584, 450);
            Controls.Add(lblCourseID);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseName);
            Controls.Add(txtCourseName);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblDuration);
            Controls.Add(txtDuration);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvCourses);
            Name = "CourseForm";
            Text = "Course Management";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCourses;
        private TextBox txtCourseID;
        private Label lblCourseID;
    }
}
