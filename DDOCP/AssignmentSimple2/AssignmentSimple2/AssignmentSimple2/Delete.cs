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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = tbname.Text;
            String pass = tbpw.Text;
            List<Staff> arr = new List<Staff>();
            StreamReader sr = new StreamReader("Staff.txt");
            String line;
            while((line=sr.ReadLine())!=null)
            {
                Staff s = new Staff(line);
                if(!(name.Equals(s.getName())&&pass.Equals(s.getPassword())))
                {
                    arr.Add(s);
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("Staff.txt");
            foreach(Staff st in arr)
            {
                sw.WriteLine(st.getString());
            }
            sw.Close();
            MessageBox.Show("Success");
        }
    }
}
