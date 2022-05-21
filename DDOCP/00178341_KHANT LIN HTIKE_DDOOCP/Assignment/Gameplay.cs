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
    public partial class Gameplay : Form
    {
        private DateTime now = DateTime.Now;
        private List<Button> evs = new List<Button>();
        private List<Button> vs = new List<Button>();
        private Dictionary<Button, Button> pair = new Dictionary<Button, Button>();
        private Button bevs, bovs;
        private int s1 = 0, s2 = 0, cc = 0;

        public Gameplay(List<Vocabs> vl)
        {
            InitializeComponent();
            MessageBox.Show(vl.Count.ToString());
            int ec = 24, oc = 1;
            foreach(Vocabs v in vl)
            {
                Button temp1 = (Button)this.Controls["button" + ec];
                Button temp2 = (Button)this.Controls["b" + oc];
                ec++;
                oc++;
                temp1.Text = v.EngVocabs;
                temp2.Text = v.OtherVocabs;
                temp1.ForeColor = temp1.BackColor;
                temp2.ForeColor = temp2.BackColor;
                temp1.Click += new EventHandler(first_click);
                temp2.Click += new EventHandler(second_click);
                pair.Add(temp1, temp2);
            }
        }

        private void first_click(object sender, EventArgs e)
        {
            bevs = (Button)sender;
            bevs.ForeColor = Color.Red;
            if (bovs != null)
                bovs.ForeColor = bovs.BackColor;
        }

        private void second_click(object sender, EventArgs e)
        {
            bovs = (Button)sender;
            bovs.ForeColor = Color.Green;
            cc++;
            if(bevs!=null)
            {
                bevs.ForeColor = bevs.BackColor;
                if(pair[bevs].Equals(bovs))
                {
                    bevs.Hide();
                    bovs.Hide();
                    if (cc % 2 == 0)
                        s2++;
                    else
                        s1++;
                }
            }
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Result r = new Result(s1,s2,cc,(DateTime.Now-now).Seconds);
            this.Hide();
            r.Show();
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {

        }
    }
}
