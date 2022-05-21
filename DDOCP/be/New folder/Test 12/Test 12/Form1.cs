using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_12
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
            String ans = "Factors of "+n+" are:";
            for (int i=1; i <= n; i++)
            {
                if (n % i == 0)
                    ans += i + " ";
            }
            lans.Text = ans;
        }
    }
}
