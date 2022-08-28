using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Validations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isValid1()
        {
            string phonePattern = "^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$";

            if (tbPhone.Text == String.Empty)
            {
                tbPhone.BackColor = Color.Pink;
                tbPhone.Focus();
                MessageBox.Show("Enter all fields!");
                return false;
            }
            else if (Regex.IsMatch(tbPhone.Text, phonePattern) == false)
            {
                tbPhone.BackColor = Color.Pink;
                tbPhone.Focus();
                MessageBox.Show("Incorrect!!");
                return false;
            }
            else return true;
        }

        private bool isValid2()
        {
            string emailPattern = "[a-z0-9]+@[a-z]+\\.[a-z]{2,3}";
            if (tbEmail.Text == String.Empty)
            {
                tbEmail.BackColor = Color.Pink;
                tbEmail.Focus();
                MessageBox.Show("Enter all fields!");
                return false;
            }
            else if (Regex.IsMatch(tbEmail.Text, emailPattern) == false)
            {
                tbEmail.BackColor = Color.Pink;
                tbEmail.Focus();
                MessageBox.Show("Incorrect!!");
                return false;

            }
            else return true;
        }

        private bool isValid3()
        {
            string cnicPattern = "^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$";
            if (tbCnic.Text == String.Empty)
            {
                tbCnic.BackColor = Color.Pink;
                tbCnic.Focus();
                MessageBox.Show("Enter all fields!");
                return false;
            }
            else if (Regex.IsMatch(tbCnic.Text, cnicPattern) == false)
            {
                tbCnic.BackColor = Color.Pink;
                tbCnic.Focus();
                MessageBox.Show("Incorrect!!");
                return false;
            }
            else return true;
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            if (isValid1())
            {
                tbPhone.BackColor = Color.LightGreen;
                MessageBox.Show("Correct!");
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (isValid2())
            {
                tbEmail.BackColor = Color.LightGreen;
                MessageBox.Show("Correct!");
            }
        }

        private void btnCnic_Click(object sender, EventArgs e)
        {
            if(isValid3())
            {
                tbCnic.BackColor = Color.LightGreen;
                MessageBox.Show("Correct!");
            }
        }
    }
}
