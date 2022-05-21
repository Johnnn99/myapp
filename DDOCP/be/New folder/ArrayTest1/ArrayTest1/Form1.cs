using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ArrayTest1
{
    public partial class Form1 : Form
    {
        private List<Int32> l = new List<Int32>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if(tbnum.Text.Length==0)
            {
                MessageBox.Show("Enter a number");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(tbnum.Text);
                    l.Add(num);
                    MessageBox.Show("There are " + l.Count + " items.");
                }catch(FormatException)
                {
                    MessageBox.Show("Enter number format");
                }
            }
        }

        private void btdisplay_Click(object sender, EventArgs e)
        {
            String r = "Number:";
            for(int i=0;i<l.Count;i++)
            {
                r += l[i] + " ";
            }
            lans.Text = r;
        }

        private void bttotal_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i=0;i<l.Count;i++)
            {
                total += l[i];
            }
            lans.Text = "The total is "+ total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
