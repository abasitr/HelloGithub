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
    public partial class FormEnroll : Form
    {
        public FormEnroll()
        {
            InitializeComponent();
        }

        private void CoursesUI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEnroll_Load(object sender, EventArgs e)
        {
            var courses = CourseDAO.GetCourses();

            foreach (var course in courses)
            {
                coursesUI.Items.Add(course.Name);
            }
        }
    }
}
