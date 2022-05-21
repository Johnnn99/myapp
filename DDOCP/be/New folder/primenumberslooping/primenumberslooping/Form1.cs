using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primenumberslooping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbnum.Text);
            int div = 2;
            while(n%div!=0)
            {
                div++;
            }
            if(n==div)
                MessageBox.Show(n+" is prime number");
            else
                MessageBox.Show(n+" is no prime number");
        }
    }
}
