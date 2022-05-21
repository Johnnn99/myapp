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
    public partial class Updat : Form
    {
        public Updat()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            String name = tbname.Text;
            String curp = tbpassword.Text;
            String newp = tbnewpass.Text;
            String rep = tbrepass.Text;
            if(newp.Equals(rep))
            {
                List<Staff> arr = new List<Staff>();
                StreamReader sr = new StreamReader("Staff.txt");
                String line;
                while((line=sr.ReadLine())!=null)
                {
                    Staff s = new Staff(line);
                    if(name.Equals(s.getName())&&curp.Equals(s.getPassword()))
                    {
                        s.setPassword(newp);
                    }
                    arr.Add(s);
                }
                sr.Close();
                StreamWriter sw = new StreamWriter("Staff.txt");
                foreach(Staff st in arr)
                {
                    sw.WriteLine(st.getString());
                }
                sw.Close();
                MessageBox.Show("Finished!");
            }
            else
            {
                MessageBox.Show("Passwords unmatch!");
            }
        }
    }
}
