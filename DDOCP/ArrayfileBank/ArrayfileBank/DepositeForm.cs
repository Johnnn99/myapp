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
namespace ArrayFileBank
{
    public partial class DepositeForm : Form
    {
        public DepositeForm()
        {
            InitializeComponent();
        }

        private void btndeposite_Click(object sender, EventArgs e)
        {
            String uaccountno = LoginForm.accno;
            int amount=Convert.ToInt32(tbamount.Text);

            //read from file
            StreamReader sr = new StreamReader("accounts.txt");
            List<BankAccount> arr = new List<BankAccount>();
            String line;
            while((line=sr.ReadLine())!=null)
            {
                BankAccount bc = new BankAccount(line);
                if(uaccountno.Equals(bc.getAccountNo()))
                {
                    bc.deposite(amount);
                }
                arr.Add(bc);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("accounts.txt");
            for(int i=0;i<arr.Count;i++)
            {
                sw.WriteLine(arr[i].getString());
            }
            sw.Close();
            MessageBox.Show("SUccess");
        }
    }
}
