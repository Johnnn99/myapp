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
    public partial class wordset : Form
    {        
        public wordset(String language)
        {
            InitializeComponent();
            languageLabel.Text = language;           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id=GameAssignmentDbHandler.GVocabType(languageLabel.Text, "Animals");
            if(id==-1)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                List<Vocabs> vl = GameAssignmentDbHandler.getVocabs(id);
                Gameplay g = new Gameplay(vl);
                this.Hide();
                g.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = GameAssignmentDbHandler.GVocabType(languageLabel.Text, "Foods");
            if (id == -1)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                List<Vocabs> vl = GameAssignmentDbHandler.getVocabs(id);
                Gameplay g = new Gameplay(vl);
                this.Hide();
                g.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=GameAssignmentDbHandler.GVocabType(languageLabel.Text, "Stationeries");
            if (id == -1)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                List<Vocabs> vl = GameAssignmentDbHandler.getVocabs(id);
                Gameplay g = new Gameplay(vl);
                this.Hide();
                g.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = GameAssignmentDbHandler.GVocabType(languageLabel.Text, "Vegetables");
            if (id == -1)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                List<Vocabs> vl = GameAssignmentDbHandler.getVocabs(id);
                Gameplay g = new Gameplay(vl);
                this.Hide();
                g.Show();
            }
        }

        private void languageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
