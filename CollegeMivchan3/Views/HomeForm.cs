using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMivchan3.Views
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            LogInStudentForm sf = new LogInStudentForm();
            sf.Show();
            this.Hide();
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecretForm secretForm = new SecretForm();
            secretForm.Show();
            this.Hide();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
