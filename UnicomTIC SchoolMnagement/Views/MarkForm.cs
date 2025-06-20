using System;
using System.Windows.Forms;

namespace UnicomTIC_SchoolMnagement.Views
{
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent(); // MUST BE PRESENT
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            // your logic
        }

        private void btnAddMark_Click(object sender, EventArgs e) { }
        private void btnUpdateMark_Click(object sender, EventArgs e) { }
        private void btnDeleteMark_Click(object sender, EventArgs e) { }
        private void btnClear_Click(object sender, EventArgs e) { }
        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
