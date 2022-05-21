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

namespace assigmentsample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbemail.Text = "";
            tbpassword.Text = "";
            lloginerr.Text = "";
            lemailerr.Text = "";
            lpassworderr.Text = "";
            tbemail.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbemail.Text.Length==0)
            {
                lemailerr.Text="****";
            }
            else
            {
                lemailerr.Text="";
            }
            if(tbpassword.Text.Length==0)
            {
                lpassworderr.Text = "****";
            }
            else
            {
                lpassworderr.Text = "";
            }
            if(lemailerr.Text.Length==0 && lpassworderr.Text.Length==0)
            {
                String useremail = tbemail.Text;
                String userpassword = tbpassword.Text;
                bool ans = false;
                StreamReader sr = new StreamReader("Staffs.txt");
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Staff s = new Staff(line);
                    if (useremail.Equals(s.getemail()) && userpassword.Equals(s.getpassword()))
                    {
                        ans = true;
                        break;
                    }
                }
                if(ans==true)
                {
                    MessageBox.Show("Login successful");
                    this.Hide();
                    Accountregister ar = new Accountregister();
                    ar.Show();
                }
                else
                {
                    lloginerr.Text = "login fall";
                    tbemail.Text = "";
                    tbpassword.Text = "";
                    tbemail.Focus();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }
    }
}
