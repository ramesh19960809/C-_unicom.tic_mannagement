namespace UnicomTICManagementSystem.Views
{
    partial class StudentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCourseID;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtEmail = new TextBox();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtPhone = new TextBox();
            txtCourseID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblEmail = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            lblPhone = new Label();
            lblCourseID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(120, 20);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(120, 60);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 23);
            txtStudentName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(120, 140);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 7;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(120, 180);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 220);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(120, 260);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(100, 23);
            txtCourseID.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(320, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.Location = new Point(20, 360);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(733, 200);
            dgvStudents.TabIndex = 18;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(20, 20);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(100, 23);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            lblStudentName.Location = new Point(20, 60);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(100, 23);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.Location = new Point(20, 180);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(100, 23);
            lblDOB.TabIndex = 8;
            lblDOB.Text = "DOB";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 220);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            // 
            // lblCourseID
            // 
            lblCourseID.Location = new Point(20, 260);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(100, 23);
            lblCourseID.TabIndex = 12;
            lblCourseID.Text = "Course ID";
            // 
            // StudentsForm
            // 
            ClientSize = new Size(801, 580);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentName);
            Controls.Add(txtStudentName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblDOB);
            Controls.Add(dtpDOB);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblCourseID);
            Controls.Add(txtCourseID);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvStudents);
            Name = "StudentsForm";
            Text = "Student Management";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
