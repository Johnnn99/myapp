using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test17
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
            if (tbnum.Text.Length == 0)
            {
                MessageBox.Show("Please enter a number!!!");
                tbnum.Focus();
            }
            else
            {
                double n = 0.0;
                bool isError = false;
                try
                {
                    n = Convert.ToInt32(tbnum.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter number format!!!");
                    tbnum.Text = "";
                    tbnum.Focus();
                    isError = true;
                }
               if (isError == false)
               {
                    string r = "Series;" + 1;
                    double ans = 1.0;
                     for (int i = 2; i <= n; i++)
                       {
                           ans += 1.0 / i;

                         r += "+"+"1/"+i;
                                
                            }
                   lans.Text = r + "=" + ans;
                        }
                    }
                }
            }
        

        
    }
        
    

