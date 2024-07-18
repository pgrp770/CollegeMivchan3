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
    public partial class AboutUsForm : Form
    {
        CoursesRepository coursesRepository;
        CallBackRepository callBackRepository;
        public AboutUsForm()
        {
            InitializeComponent();
            coursesRepository = new CoursesRepository();
            callBackRepository = new CallBackRepository();
            RefreshPage();
        }

        public void RefreshPage()
        {
            comboBoxCourseName.DataSource = coursesRepository.GetAllCoursesName();
            comboBoxMachzor.DataSource = coursesRepository.GetAllMachzorimByCourseName(comboBoxCourseName.Text);
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

        private void buttonRequiste_Click(object sender, EventArgs e)
        {
            callBackRepository.SendRequist(textBoxNameRequiste.Text, textBoxRequiste.Text);
            textBoxNameRequiste.Text = "";
            textBoxRequiste.Text = "";
        }

        private void AboutUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
