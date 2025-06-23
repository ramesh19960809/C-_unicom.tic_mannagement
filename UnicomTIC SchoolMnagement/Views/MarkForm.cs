using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Controllers;
using YourNamespace.Controllers;
using YourNamespace.Models;

namespace UnicomTIC_SchoolMnagement.Views
{
    public partial class MarkForm : Form
    {
        private MarkController _controller;

        public MarkForm()
        {
            InitializeComponent();
            _controller = new MarkController();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadMarksToGrid();
            ClearFields();
        }

        private void LoadMarksToGrid()
        {
            List<Mark> marks = _controller.GetAllMarks();
            dgvMarks.DataSource = null;
            dgvMarks.DataSource = marks;
        }

        private void ClearFields()
        {
            txtStudentId.Text = "";
            txtSubjectId.Text = "";
            txtMark.Text = "";
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "" || txtSubjectId.Text == "" || txtMark.Text == "")
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            Mark mark = new Mark
            {
                StudentId = int.Parse(txtStudentId.Text),
                SubjectId = int.Parse(txtSubjectId.Text),
                Score = int.Parse(txtMark.Text)
            };

            bool added = _controller.AddMark(mark);
            if (added)
            {
                MessageBox.Show("Mark added successfully.");
                LoadMarksToGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add mark.");
            }
        }

        private void btnUpdateMark_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "" || txtSubjectId.Text == "")
            {
                MessageBox.Show("Select a mark to update.");
                return;
            }

            Mark mark = new Mark
            {
                StudentId = int.Parse(txtStudentId.Text),
                SubjectId = int.Parse(txtSubjectId.Text),
                Score = int.Parse(txtMark.Text)
            };

            bool updated = _controller.UpdateMark(mark);
            if (updated)
            {
                MessageBox.Show("Mark updated successfully.");
                LoadMarksToGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update mark.");
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "" || txtSubjectId.Text == "")
            {
                MessageBox.Show("Select a mark to delete.");
                return;
            }

            int studentId = int.Parse(txtStudentId.Text);
            int subjectId = int.Parse(txtSubjectId.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool deleted = _controller.DeleteMark(studentId, subjectId);
                if (deleted)
                {
                    MessageBox.Show("Mark deleted.");
                    LoadMarksToGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete mark.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMarks.Rows[e.RowIndex];
                txtStudentId.Text = row.Cells["StudentID"].Value.ToString();
                txtSubjectId.Text = row.Cells["SubjectID"].Value.ToString();
                txtMark.Text = row.Cells["Score"].Value.ToString();
            }
        }
    }
}
