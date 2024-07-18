using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeMivchan3.Dal.Repositories;

namespace CollegeMivchan3.Views
{
    public partial class LogInStudentForm : Form
    {
        StudentRepository studentRepository;
        public LogInStudentForm()
        {
            studentRepository = new StudentRepository();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkPassword = studentRepository.CheckPassword(textBoxPassword.Text, textBoxName.Text);
            if (!checkPassword)
            {
                MessageBox.Show("You inputed wrong ditails");
                return;
            }
            StudentForm studentForm = new StudentForm(textBoxName.Text);
            this.Hide();
            studentForm.Show();
        }

        private void LogInStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
