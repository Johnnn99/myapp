using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            if (tbname1.TextLength == 0)
            {
                lname.Text = "***";
            }
            else
            {
                lname.Text = "";
            }
            if (tbmail1.TextLength == 0)
            {
                lemail.Text = "***";
            }
            else
            {
                lemail.Text = "";
            }
            if (tbpassword1.TextLength == 0)
            {
                lpw.Text = "***";
            }
            else
            {
                lpw.Text = "";
            }
            if (tbrepassword1.TextLength == 0)
            {
                lrpw.Text = "***";
            }
            else
            {
                lrpw.Text = "";
            }
            if (tbpassword1.Text != tbrepassword1.Text)
            {
                MessageBox.Show("Password must be match!");
            }
            else
            {
                if (tbname1.Text.Length == 0 || tbmail1.Text.Length == 0 || tbpassword1.Text.Length == 0 || tbrepassword1.Text.Length == 0)
                {
                    MessageBox.Show("Don't blank anything please!");
                }
                else
                {
                    String name1 = tbname1.Text;
                    
                    String email1 = tbmail1.Text;
                    
                    String password1 = tbpassword1.Text;
                    
                    bool ans=GameAssignmentDbHandler.GPlayerRegister(name1, email1, password1);
                    if(ans)
                    {
                        MessageBox.Show("Registration Complete");
                        Login l = new Login();
                        this.Hide();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Someting went Wrong!");
                    }

                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
