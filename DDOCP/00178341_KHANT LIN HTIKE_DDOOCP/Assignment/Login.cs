using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       private void btnLogin_Click(object sender, EventArgs e)
        {
           if(tbemail1.TextLength==0)
           {
               lemail.Text = "***";
           }
           else
           {
               lemail.Text = "";
           }
           if(tbemail2.TextLength==0)
           {
               lemail1.Text = "***";
           }
           else
           {
               lemail1.Text = "";
           }
           if(tbpassword1.TextLength==0)
           {
               lpw.Text = "***";
           }
           else
           {
               lpw.Text = "";
           }
           if(tbpassword2.TextLength==0)
           {
               lpw1.Text = "***";
           }
           else
           {
               lpw1.Text = "";
           }
           if(tbemail1.Text.Length==0 || tbemail2.Text.Length==0 || tbpassword1.Text.Length==0 || tbpassword2.Text.Length==0)
           {

           }
           else
           {
               int firstPlayer = GameAssignmentDbHandler.Loginform(tbemail1.Text, tbpassword1.Text);
               int secondPlayer = GameAssignmentDbHandler.Loginform(tbemail2.Text, tbpassword2.Text);
               if(firstPlayer==-1 || secondPlayer==-1)
               {
                   MessageBox.Show("Wrong emails or passwords");
               }
               else
               {
                   MessageBox.Show("Login Successful");
                   Players.FirstGamer = firstPlayer;
                   Players.SecondGamer = secondPlayer;
                   this.Hide();
                   Language l = new Language();
                   l.Show();
               }
           }
           
        }

       private void button1_Click(object sender, EventArgs e)
       {
           this.Hide();
           Register r = new Register();
           r.Show();
       }
    }
}
