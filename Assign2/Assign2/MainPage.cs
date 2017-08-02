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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            form.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblCollege.Text = "Mini College Application " + DateTime.Now.ToShortDateString();
            MaximizeBox = false;
            MinimizeBox = true;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var form = new FormEnroll();
            form.ShowDialog();
        }
    }
}
