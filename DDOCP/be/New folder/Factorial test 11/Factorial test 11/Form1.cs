using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_test_11
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
            int ans = 1;
            for (int i=n; i>0; i--)
            {
                ans *= i;
            }
            MessageBox.Show(n + " !=" + ans);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
