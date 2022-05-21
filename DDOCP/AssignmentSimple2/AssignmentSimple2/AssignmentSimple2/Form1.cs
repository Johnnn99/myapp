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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = Convert.ToInt32(tbsid.Text);
                String name = tbname.Text;
                String email = tbemail.Text;
                String phone = tbphone.Text;
                String password = tbpassword.Text;
                String repassword = tbrepassword.Text;
                String gender;
                if (rbmale.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";
                String position = (String)cbposition.SelectedItem;

                if(password.Equals(repassword))
                {
                    Staff s = new Staff(sid, name, email, phone, password, gender, position);
                    String line = s.getString();
                    StreamWriter sw = new StreamWriter("Staff.txt", true);
                    sw.WriteLine(line);
                    sw.Close();
                    MessageBox.Show("Successfully Finished!!");

                    tbsid.Text = "";
                    tbname.Text = "";
                    tbemail.Text="";
                    tbphone.Text="";
                    tbpassword.Text = "";
                    tbrepassword.Text = "";
                    rbmale.Checked = true;
                    cbposition.Text = "";
                    tbsid.Focus();
                }
                else
                {
                    MessageBox.Show("Passwords are not equals!!");
                    tbpassword.Text="";
                    tbrepassword.Text = "";
                    tbpassword.Focus();
                }
            }catch(FormatException)
            {
                MessageBox.Show("Sid must be number!!");
                tbsid.Text = "";
                tbsid.Focus();
            }
        }

        private void btngosearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Updat u = new Updat();
            this.Hide();
            u.Show();
        }

        private void BTdl_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            this.Hide();
            d.Show();
        }
    }
}
