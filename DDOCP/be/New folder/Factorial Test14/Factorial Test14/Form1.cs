using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Test14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            if(tbnum.Text.Length==0)
            {
                MessageBox.Show("Please enter a number!!!");
                tbnum.Focus();
            }
            else
            {
                int n = 0;
            }
        }
    }
}
