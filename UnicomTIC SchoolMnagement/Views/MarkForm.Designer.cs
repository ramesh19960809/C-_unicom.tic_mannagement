namespace UnicomTIC_SchoolMnagement.Views
{
    partial class MarkForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnUpdateMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Text = "Enter Student Marks";

            // lblStudentId
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(30, 70);
            this.lblStudentId.Text = "Student ID";

            // lblSubjectId
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Location = new System.Drawing.Point(30, 110);
            this.lblSubjectId.Text = "Subject ID";

            // lblMark
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(30, 150);
            this.lblMark.Text = "Mark";

            // txtStudentId
            this.txtStudentId.Location = new System.Drawing.Point(130, 70);
            this.txtStudentId.Size = new System.Drawing.Size(200, 22);

            // txtSubjectId
            this.txtSubjectId.Location = new System.Drawing.Point(130, 110);
            this.txtSubjectId.Size = new System.Drawing.Size(200, 22);

            // txtMark
            this.txtMark.Location = new System.Drawing.Point(130, 150);
            this.txtMark.Size = new System.Drawing.Size(200, 22);

            // btnAddMark
            this.btnAddMark.Location = new System.Drawing.Point(30, 190);
            this.btnAddMark.Text = "Add Mark";
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);

            // btnUpdateMark
            this.btnUpdateMark.Location = new System.Drawing.Point(130, 190);
            this.btnUpdateMark.Text = "Update";
            this.btnUpdateMark.Click += new System.EventHandler(this.btnUpdateMark_Click);

            // btnDeleteMark
            this.btnDeleteMark.Location = new System.Drawing.Point(230, 190);
            this.btnDeleteMark.Text = "Delete";
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(330, 190);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvMarks
            this.dgvMarks.Location = new System.Drawing.Point(30, 240);
            this.dgvMarks.Size = new System.Drawing.Size(500, 200);
            this.dgvMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarks_CellClick);

            // MarkForm
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblSubjectId);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.btnUpdateMark);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvMarks);
            this.Name = "MarkForm";
            this.Text = "Mark Entry";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnUpdateMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvMarks;
    }
}
