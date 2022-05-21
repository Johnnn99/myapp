using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(tbw.Text) * 0.454;
            double h = Convert.ToDouble(tbh.Text) * 0.025;
            double ans = w / (h * h);
            MessageBox.Show("Your BMI is " + ans);
        }
    }
}
