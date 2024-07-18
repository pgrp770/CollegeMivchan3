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
    public partial class SecretForm : Form
    {
        PaymentReposirtory paymentReposirtory;
        public SecretForm()
        {
            paymentReposirtory = new PaymentReposirtory();
            InitializeComponent();
            double income = paymentReposirtory.TotalIncomeFromStudents();
            label2.Text = income.ToString();
            double outcome = paymentReposirtory.TotalSalaryProffesors();
            label4.Text = outcome.ToString();
            double totalIncome = income - outcome;
            label6.Text = (totalIncome).ToString();
            if (totalIncome > 0)
            {
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.ForeColor = Color.Red;
            }
            int procent = Convert.ToInt32((income - outcome) / outcome * 100);
            if (procent > 30)
            {
                label7.Text = procent + "%";
                label7.ForeColor = Color.Green;
            }
            else
            {
                label7.Text = "the revach is not good yet";
                label7.ForeColor = Color.Red;
            }

        }

        private void SecretForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
