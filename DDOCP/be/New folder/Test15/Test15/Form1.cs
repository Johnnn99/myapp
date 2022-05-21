using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test15
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
            String r = "";
            for(int i=1; i<=5; i++)
            {
                if(i != 0)
                {
                    r += i + "\n";
                }
                else
                {
                    r += i;
                }
            }
            lans.Text = r;
        }
    }
}
