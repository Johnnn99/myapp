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
    public partial class Accountregister : Form
    {
        public Accountregister()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbaccount.Text = "";
            tbname.Text = "";
            tbnrc.Text = "";
            tbphone.Text = "";
            tbdob.Text = "";
            tbpassword.Text = "";
            tbrepassword.Text = "";
            tbamount.Text = "";
            tbaccount.Focus();
            laccounterr.Text = "";
            lnamerr.Text = "";
            lnrcerr.Text = "";
            lphonerr.Text = "";
            ldoberr.Text = "";
            lpassword.Text = "";
            lrepassworderr.Text = "";
            lamounterr.Text = "";
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            bool ans = true; 
            if(tbaccount.Text.Length==0)
            {
                laccounterr.Text = "****";
                ans = false;
            }
            else
            {
                laccounterr.Text = "";
            }
            if(tbname.Text.Length==0)
            {
                lnamerr.Text = "****";
                ans = false;
            }
            else
            {
                lnamerr.Text = "";
            }
            if(tbnrc.Text.Length==0)
            {
                lnrcerr.Text = "****";
                ans = false;
            }
            else
            {
                lnrcerr.Text = "";
            }
            if(tbphone.Text.Length==0)
            {
                lphonerr.Text = "****";
                ans = false;
            }
            else
            {
                lphonerr.Text = "";
            }
            if(tbdob.Text.Length==0)
            {
                ldoberr.Text = "****";
                ans = false;
            }
            else
            {
                ldoberr.Text = "";
            }
            if(tbpassword.Text.Length==0)
            {
                lpassword.Text = "****";
                ans = false;
            }
            else
            {
                lpassword.Text = "";
            }
            if(tbrepassword.Text.Length==0)
            {
                lrepassworderr.Text = "****";
            }
            else
            {
                lrepassworderr.Text = "";
            }
            if(tbamount.Text.Length==0)
            {
                lamounterr.Text = "****";
                ans = false;
            }
            else
            {
                lamounterr.Text = "";
            }
            if(ans==true)
            {
                String ac = tbaccount.Text;
                String n = tbname.Text;
                String nr = tbnrc.Text;
                String p = tbphone.Text;
                String d = tbdob.Text;
                String pa = tbpassword.Text;
                String re = tbrepassword.Text;
                double amount = Convert.ToDouble(tbamount.Text);
                try
                {
                    if(pa.Equals(re))
                    {
                        double a = Convert.ToDouble(tbamount.Text);
                        Account fa=new Account(ac, n, nr, p, d, pa, a);
                        String ea = fa.getString();
                        StreamWriter gg = new StreamWriter("accountregister.txt", true);
                        gg.WriteLine(ea);
                        gg.Close();
                        MessageBox.Show("Successfully added");
                        tbaccount.Text = "";
                        tbname.Text = "";
                        tbnrc.Text = "";
                        tbphone.Text = "";
                        tbdob.Text = "";
                        tbpassword.Text = "";
                        tbrepassword.Text = "";
                        tbamount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Not Equal");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter a number");
                }
            }
        }
    }
}
