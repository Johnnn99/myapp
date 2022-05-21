using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            //Validation
            if(tbnum.Text.Length==0)
            {
                MessageBox.Show("Please enter a number!!!");
                tbnum.Focus();
            }
            else
            {
                int n = 0;
                bool isError = false;
                try
                {
                    n = Convert.ToInt32(tbnum.Text);
                }catch(FormatException)
                {
                    MessageBox.Show("Please enter a Number Format!!");
                    tbnum.Text = "";
                    tbnum.Focus();
                    isError = true;
                }
                if(isError==false)
                {
                    int ans = 1;
                    String r="";
                    
                    for(int i=1; i<=12; i++)
                    {
                        ans = n * i;
                        r += n + "*"+i+"=" + ans + "\n";
                      
                    }
                    lans.Text = r;
                }
            }
        }
    }
}
