using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbnum1.Text);
            int n2 = Convert.ToInt32(tbnum2.Text);
            int ans = n1 % n2;
            MessageBox.Show(n1 + " % " + " = " + ans);
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbnum1.Text);
            int n2 = Convert.ToInt32(tbnum2.Text);
            int ans = n1 + n2;
            MessageBox.Show(n1 + " + " + n2 + " = " +ans);
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbnum1.Text);
            int n2 = Convert.ToInt32(tbnum2.Text);
            int ans = n1 - n2;
            MessageBox.Show(n1 + " - " + n2 + " = " + ans);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbnum1.Text);
            int n2 = Convert.ToInt32(tbnum2.Text);
            int ans = n1 * n2;
            MessageBox.Show(n1 + " * " + n2 + " = " + ans);
        }

        private void btdi_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbnum1.Text);
            int n2 = Convert.ToInt32(tbnum2.Text);
            int ans = n1 / n2;
            MessageBox.Show(n1 + " / " + n2 + " = " + ans);
        }
    }
}
