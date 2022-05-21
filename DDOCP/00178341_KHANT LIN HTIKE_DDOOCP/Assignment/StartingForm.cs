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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnewgame_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wordrepair w = new Wordrepair();
            this.Hide();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wordsetrepair w = new Wordsetrepair();
            this.Hide();
            w.Show();
        }
    }
}
