using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArrayFileBank
{
    public partial class LoginForm : Form
    {
        public static string accno;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lerr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbaccountno.Text.Length==0 || tbpassword.Text.Length==0)
            {
                lerr.Text = "Please Fill";
            }
            else
            {
                String useraccountno = tbaccountno.Text;
                accno = tbaccountno.Text;
                String userpassword = tbpassword.Text;
                bool found = false;
                StreamReader sr = new StreamReader("accounts.txt");
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    BankAccount bc = new BankAccount(line);
                    if (bc.getAccountNo().Equals(useraccountno) && bc.getPassword().Equals(userpassword))
                    {
                        found = true;
                        break;
                    }
                }
                sr.Close();
                if (found == false)
                {
                    lerr.Text = "Try Again!";
                    tbaccountno.Text = "";
                    tbpassword.Text = "";
                    tbaccountno.Focus();
                }
                else
                {
                    this.Hide();
                    Menu m = new Menu();
                    m.Show();
                }
            }
        }
    }
}
