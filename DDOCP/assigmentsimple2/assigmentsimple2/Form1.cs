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

namespace assigmentsimple2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sid=Convert.ToInt32(tbsid.Text);
                String name=tbname.Text;
                String email=tbemail.Text;
                String phone=tbphone.Text;
                String password=tbpassword.Text;
                String repassword=tbrepassword.Text;
                String gender;
                {
                    gender="male";
                }
                else
                {
                    gender="female";
                }
                String position=(String) cbposition.SelectedItem;
                if(password.Equals(repassword))
                {
                    Staff ar=new Staff(sid,name,email,phone,password,gender,position);
                    String line=ar.getstring();
                    StreamWriter tt=new StreamWriter("Staff.txt",true);
                    tt.WriteLine(line);
                    tt.Close();
                    MessageBox.Show("Successfully added");
                    tbsid.Text="";
                }
            }catch(Exception)
            {
                MessageBox.Show{"Sid must be number"};
                tbsid.Text="";
                tbsid.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
