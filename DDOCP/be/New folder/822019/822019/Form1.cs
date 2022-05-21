using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _822019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tbid.Text);
            String n = tbname.Text;
            String m = tbmajor.Text;
            int y = Convert.ToInt32(tbyear.Text);
            String g = tbgender.Text;
            String s = i + "," + n + "," + y + "," + g;
            StreamWriter ww = new StreamWriter("admin.txt", true);
            ww.WriteLine(s);
            ww.Close();
            MessageBox.Show("Successfully Added");
        }
    }
}
