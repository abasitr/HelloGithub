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
    public partial class courseForm : Form
    {

        private Course _activeCourse;
        public courseForm()
        {
            InitializeComponent();
        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }

        private void courseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            _activeCourse = new Course();
            _activeCourse.Name = txtCName.Text;

            CourseDAO.Create(_activeCourse);
            MessageBox.Show("COurse has been added", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var course = int.Parse(txtCName.Text);

            var result = MessageBox.Show("Are you sure you want to delete the student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CourseDAO.Delete(_activeCourse);
                
                txtCName.Clear();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _activeCourse.Name = txtCName.Text;
           CourseDAO.Update(_activeCourse);
        }
    }
}
