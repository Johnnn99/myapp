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

namespace uni_project_yourname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbstudent.Text = "";
            tbname.Text = "";
            cbmajor.SelectedIndex = -1;
            cbyear.SelectedIndex = -1;
            rbmale.Checked = true;
            tbdob.Text = "";
            tbpassword.Text = "";
            tbrepassword.Text = "";
            tbstudent.Focus();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            bool isErrorFree = true;
            if (tbstudent.Text.Length == 0)
            {
                lstudenterr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lstudenterr.Text = "";
            }
            if (tbname.Text.Length == 0)
            {
                lnameerr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lnameerr.Text = "";
            }
            if (cbmajor.SelectedIndex == -1)
            {
                lmajorerr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lmajorerr.Text = "";
            }
            if (cbyear.SelectedIndex == -1)
            {
                lyearerr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lyearerr.Text = "";
            }
            if (tbdob.Text.Length == 0)
            {
                ldoberr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                ldoberr.Text = "";
            }
            if (tbpassword.Text.Length == 0)
            {
                lpassworderr.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lpassworderr.Text = "";
            }
            if (tbrepassword.Text.Length == 0)
            {
                lrepassword.Text = "****";
                isErrorFree = false;
            }
            else
            {
                lrepassword.Text = "";
            }
            if (isErrorFree == true)
            {
                int s = Convert.ToInt32(tbstudent.Text);
                String n = tbname.Text;
                String m = (String)cbmajor.SelectedItem;
                String y = (String)cbyear.SelectedItem;
                String g = "";
                if (rbmale.Checked == true)
                {
                    g = "male";
                }
                else
                {
                    g = "female";
                }
                String d = tbdob.Text;
                String p = tbpassword.Text;
                String re = tbrepassword.Text;
                try
                {
                    if (p.Equals(re))
                    {
                        yourname ga = new yourname(s, n, m, y, g, d, p);
                        String r = ga.getString();
                        StreamWriter gg = new StreamWriter("yourname.txt", true);
                        gg.WriteLine(r);
                        gg.Close();
                        MessageBox.Show("Successfully added");
                        tbstudent.Text = "";
                        tbname.Text = "";
                        cbmajor.SelectedIndex = -1;
                        cbyear.SelectedIndex = -1;
                        rbmale.Checked = true;
                        tbdob.Text = "";
                        tbpassword.Text = "";
                        tbrepassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("not equal");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("please enter a number");
                }
            }

        }
    }
}

