using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test10_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbn.Text);
            int ans = 0;
            for(int i=1; i<=n; i++)
            {
                ans += i;
            }
            MessageBox.Show("sum of 1 to " + n + " is " + ans);
        }
    }
}
