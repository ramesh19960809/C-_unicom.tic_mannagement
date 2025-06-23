using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentManagementSystem.Controllers;
using StudentManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class StudentsForm : Form
    {
        private StudentController _controller;

        public StudentsForm()
        {
            InitializeComponent();
            _controller = new StudentController();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            LoadStudentsToGrid();
            ClearFields();
        }

        private void LoadStudentsToGrid()
        {
            try
            {
                List<Student> students = _controller.GetAllStudents();
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtEmail.Text = "";
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            txtPhone.Text = "";
            txtCourseID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbGender.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            if (dtpDOB.Value > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be in the future.");
                return;
            }

            if (!int.TryParse(txtCourseID.Text, out int courseId) || courseId == 0)
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            Student student = new Student
            {
                Name = txtStudentName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Gender = cmbGender.SelectedItem.ToString(),
                DOB = dtpDOB.Value,
                Phone = txtPhone.Text.Trim(),
                CourseId = courseId
            };

            bool result = _controller.AddStudent(student);
            if (result)
            {
                MessageBox.Show("Student added successfully.");
                LoadStudentsToGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add student.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Select a student to update.");
                return;
            }

            if (dtpDOB.Value > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be in the future.");
                return;
            }

            if (!int.TryParse(txtCourseID.Text, out int courseId) || courseId == 0)
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            Student student = new Student
            {
                StudentId = int.Parse(txtStudentID.Text),
                Name = txtStudentName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Gender = cmbGender.SelectedItem.ToString(),
                DOB = dtpDOB.Value,
                Phone = txtPhone.Text.Trim(),
                CourseId = courseId
            };

            bool result = _controller.UpdateStudent(student);
            if (result)
            {
                MessageBox.Show("Student updated successfully.");
                LoadStudentsToGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update student.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Select a student to delete.");
                return;
            }

            int studentId = int.Parse(txtStudentID.Text);
            var confirm = MessageBox.Show("Are you sure to delete this student?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool result = _controller.DeleteStudent(studentId);
                if (result)
                {
                    MessageBox.Show("Student deleted successfully.");
                    LoadStudentsToGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.Rows[e.RowIndex].Cells.Count >= 7)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells["StudentId"].Value?.ToString() ?? "";
                txtStudentName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString() ?? "";
                dtpDOB.Value = DateTime.TryParse(row.Cells["DOB"].Value?.ToString(), out DateTime dob) ? dob : DateTime.Today;
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtCourseID.Text = row.Cells["CourseId"].Value?.ToString() ?? "";
            }
        }
    }
}
