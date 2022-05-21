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

namespace AssignmentSimple2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            String igender = tbgender.Text;
            StreamReader sr = new StreamReader("Staff.txt");
            String line;
            tbsearch.Text = "";
            while((line=sr.ReadLine())!=null)
            {
                Staff s = new Staff(line);
                if(igender.Equals(s.getGender()))
                {
                    tbsearch.AppendText(s.getString());
                }
            }
            /*String iname = tbname.Text;
            StreamReader sr = new StreamReader("Staff.txt");
            String line;
            bool found = false;
            while((line=sr.ReadLine())!=null)
            {
                Staff s = new Staff(line);
                if(iname.Equals(s.getName()))
                {
                    tbsearch.Text = s.getString();
                    found = true;
                }
            }
            if(found==false)
            {
                tbsearch.Text = "Not Found";
            }*/
        }
    }
}
