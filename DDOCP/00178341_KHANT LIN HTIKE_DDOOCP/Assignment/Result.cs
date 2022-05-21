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
    public partial class Result : Form
    {
        public Result(int si1,int si2,int cc,int t)
        {
            InitializeComponent();
            t1.Text = t + "";
            t2.Text = t + "";
            s1.Text = si1 + "";
            s2.Text = si2 + "";
            sr1.Text = si1 / (cc / 2.0) + "";
            sr2.Text = si2 / (cc / 2.0) + "";
            GameAssignmentDbHandler.SofPlayerRegister(si1, si1 / (cc / 2.0f), t, Players.FirstGamer);
            GameAssignmentDbHandler.SofPlayerRegister(si2, si2 / (cc / 2.0f), t, Players.SecondGamer);
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
