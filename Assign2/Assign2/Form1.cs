using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2
{
    public partial class StudentForm : Form
    {

        private Student _activeStudent;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var form = new FormEnroll();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var studentID = int.Parse(txtStuID.Text);
            _activeStudent = StudentDAO.GetStudent(studentID);
            if (_activeStudent == null)
            {
                MessageBox.Show("Student Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            txtFName.Text = _activeStudent.FirstName;

            txtLName.Text = _activeStudent.LastName;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtStuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var student = int.Parse(txtStuID.Text);

            var result = MessageBox.Show("Are you sure you want to delete the student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StudentDAO.Delete(_activeStudent);
                txtStuID.Clear();
                txtLName.Clear();
                txtFName.Clear();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _activeStudent.FirstName = txtFName.Text;
            _activeStudent.LastName = txtLName.Text;
            StudentDAO.Update(_activeStudent);
            txtStuID.Clear();
            txtLName.Clear();
            txtFName.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtStuID.Enabled = false;
            txtStuID.Clear(); //incase user trys to enter ID while adding
            _activeStudent = new Student();
            _activeStudent.FirstName = txtFName.Text;
            _activeStudent.LastName = txtLName.Text;

            StudentDAO.Create(_activeStudent);
            MessageBox.Show("Student has been added", "Students", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFName.Clear();
            txtLName.Clear();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
