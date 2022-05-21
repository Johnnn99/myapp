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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbaccount.Text = "";
            tbpassword.Text = "";
            laccounterr.Text = "";
            lpassword.Text = "";
            tbaccount.Focus();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if(tbaccount.Text.Length==0)
            {
                laccounterr.Text = "****";
            }
            else 
            {
                laccounterr.Text = "";
            }
            if(tbpassword.Text.Length==0)
            {
                lpassword.Text = "****";
            }
            else
            {
                lpassword.Text = "";
            }
            if(laccounterr.Text.Length==0 && lpassword.Text.Length==0)
            {
                String useraccountno = tbaccount.Text;
                String userpassword = tbpassword.Text;
                bool ans = false;
                StreamReader fa = new StreamReader("Customerfile.txt");
                 String bline;
                 while ((bline = fa.ReadLine()) != null)
                 {
                     Customerfile s = new Customerfile(bline);
                     if (useraccountno.Equals(s.getaccountno()) && userpassword.Equals(s.getpassword()))
                     {
                         ans = true;
                         break;
                     }
                     if (ans == true)
                     {
                         MessageBox.Show("Login successful");
                         this.Hide();
                         Accountregister ar = new Accountregister();
                         ar.Show();
                     }
                     else
                     {
                         lerror.Text = "login fall";
                         tbaccount.Text = "";
                         tbpassword.Text = "";
                         tbaccount.Focus();
                     }
                 }
            }
        }
    }
}
