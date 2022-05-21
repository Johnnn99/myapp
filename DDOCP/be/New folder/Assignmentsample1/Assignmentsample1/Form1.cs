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

namespace Assignmentsample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbemail.Text = "";
            tbpw.Text = "";
            lloginerr.Text = "";
            lemailerr.Text = "";
            lpwerr.Text = "";
            tbemail.Focus();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if(tbemail.Text.Length==0)
            {
                lemailerr.Text = "Please Fill!";
            }
            else
            {
                lemailerr.Text = "";
            }
            if(tbpw.Text.Length==0)
            {
                lpwerr.Text = "Please Fill!";
            }
            else
            {
                lpwerr.Text="";
            }
            if(lemailerr.Text.Length==0 && lpwerr.Text.Length==0)
            {
                String useremail=tbemail.Text;
                String userpassword=tbpw.Text;
                bool ans=false;
                StreamReader sr = new StreamReader("Staffs.txt");
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Staff s = new Staff(line);
                    if (useremail.Equals(s.getEmail()) && userpassword.Equals(s.getPassword())) 
                    {
                        ans = true;
                        break;
                    }
                }
                if(ans==true)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    lloginerr.Text = "Login Fail!";
                    tbemail.Text = "";
                    tbpw.Text = "";
                    tbemail.Focus();
                }
            }
        }
    }
}
