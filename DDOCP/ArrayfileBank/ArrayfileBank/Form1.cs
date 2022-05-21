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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbname.Text = "";
            tbnrc.Text = "";
            tbdob.Text = "";
            rbmale.Checked = true;
            cbtype.SelectedIndex = -1;
            tbamount.Text = "";
            tbname.Focus();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            bool isErrorFree = true;
            if(tbname.Text.Length==0)
            {
                lnameerr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                lnameerr.Text = "";
            }

            if(tbnrc.Text.Length==0)
            {
                lnrcerr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                lnrcerr.Text = "";
            }

            if(tbdob.Text.Length==0)
            {
                ldoberr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                ldoberr.Text = "";
            }

            if(cbtype.SelectedIndex==-1)
            {
                ltypeerr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                ltypeerr.Text = "";
            }

            if(tbamount.Text.Length==0)
            {
                lamounterr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                lamounterr.Text = "";
            }
            if(tbaccountno.Text.Length==0)
            {
                laccountnoerr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                laccountnoerr.Text = "";
            }
            if(tbpassword.Text.Length==0 || tbrepassword.Text.Length==0)
            {
                lpassworderr.Text = "***";
                isErrorFree = false;
            }
            else
            {
                lpassworderr.Text = "";
            }
            if(isErrorFree==true)
            {
                String name = tbname.Text;
                String nrc = tbnrc.Text;
                String dob = tbdob.Text;
                String gender;
                if(rbmale.Checked==true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }
                String type = (String)cbtype.SelectedItem;
                String accountNo = tbaccountno.Text;
                String password = tbpassword.Text;
                String repassword = tbrepassword.Text;
                try
                {
                    if(password.Equals(repassword))
                    {
                        double amount = Convert.ToDouble(tbamount.Text);
                    BankAccount ba = new BankAccount(name, nrc, dob, gender, type, amount,accountNo,password);
                    String s = ba.getString();
                    StreamWriter sw = new StreamWriter("accounts.txt", true);
                    sw.WriteLine(s);
                    sw.Close();
                    MessageBox.Show("Success");
                    tbname.Text = "";
                    tbnrc.Text = "";
                    tbdob.Text = "";
                    rbmale.Checked = true;
                    cbtype.SelectedIndex = -1;
                    tbamount.Text = "";
                    tbname.Focus();
                    }
                    else
                    {
                        lpassworderr.Text = "unmatch!!";
                    }
                    
                }catch(Exception)
                {
                    lamounterr.Text = "must be a number";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
