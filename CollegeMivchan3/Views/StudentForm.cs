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
    public partial class StudentForm : Form
    {
        CoursesRepository coursesRepository;
        PaymentReposirtory paymentReposirtory;
        public string Name;
        public StudentForm(string name)
        {
            InitializeComponent();
            Name = name;
            coursesRepository = new CoursesRepository();
            paymentReposirtory = new PaymentReposirtory();
            RefreshPage();
        }

        public void RefreshPage()
        {
            label8.Text = paymentReposirtory.LeftToPayOfOneStudent(Name).ToString();
            comboBoxCourseName.DataSource = coursesRepository.GetAllCoursesName();
            comboBoxMachzor.DataSource = coursesRepository.GetAllMachzorimByCourseName(comboBoxCourseName.Text);
            listBox1.DataSource = coursesRepository.GetAllCoursesNameForStudent(Name);
            label10.Text = $"Hello {Name}";
            RefreshTables();
        }

        public void RefreshTables()
        {
            dataGridView2.DataSource = coursesRepository.GetCouresSylabusByNameAndMachzor(comboBoxCourseName.Text, comboBoxMachzor.Text);
            dataGridView1.DataSource = coursesRepository.GetAllDetailTimeFromCouresByNameAndMachzor(comboBoxCourseName.Text, comboBoxMachzor.Text);
        }

        private void comboBoxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void comboBoxMachzor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void buttonBuyCourse_Click(object sender, EventArgs e)
        {
            if (coursesRepository.checkIfExistThisCourse(comboBoxCourseName.Text, comboBoxMachzor.Text, Name))
            {
                MessageBox.Show("you have alreay this course");
                return;
            }
            coursesRepository.InsertNewStudentToCourse(comboBoxCourseName.Text, comboBoxMachzor.Text, Name);
            paymentReposirtory.BuyCourses(comboBoxCourseName.Text, comboBoxMachzor.Text, Name);
            label8.Text = paymentReposirtory.LeftToPayOfOneStudent(Name).ToString();
            listBox1.DataSource = coursesRepository.GetAllCoursesNameForStudent(Name);
            MessageBox.Show("you have succssesfuly bought the course");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentReposirtory.PayAndUpdateTheLeftToPay(Name, textBox1.Text);
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
