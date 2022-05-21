using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbnum.Text);
            if (n % 2 == 0 && n >= 0)
            {
                MessageBox.Show(n + " is e+ve");
            }
            else if (n % 2 == 0 && n < 0)
            {
                MessageBox.Show(n + " is e-ve");
            }
            else if (n % 2 != 0 && n >= 0)
            {
                MessageBox.Show(n + " is o+ve");
            }
            else (n % 2 != 0 && n < 0)
            {
                MessageBox.Show(n+" is o-ve");
            }

        }
    }
}
