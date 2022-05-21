using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFileBank
{
    public class BankAccount
    {
        private String name, nrc, dob, gender, accountType;
        private double amount;
        private String accountno, password;

        public BankAccount(String line)
        {
            char[] arr = { ',' };
            String[] sarr = line.Split(arr);
            name = sarr[0];
            nrc = sarr[1];
            dob = sarr[2];
            gender = sarr[3];
            accountType = sarr[4];
            amount = Convert.ToDouble(sarr[5]);
            accountno = sarr[6];
            password = sarr[7];
        }
        public BankAccount(String name,String nrc,String dob,
            String gender,String at,double amt,String an,String p)
        {
            this.name = name;
            this.nrc = nrc;
            this.dob = dob;
            this.gender = gender;
            this.accountType = at;
            this.amount = amt;
            this.accountno = an;
            this.password = p;
        }
        public void setName(String n)
        {
            this.name = n;
        }
        public String getName()
        {
            return name;
        }
        public String getAccountNo()
        {
            return accountno;
        }
        public String getPassword()
        {
            return password;
        }
        public String getString()
        {
            return name + "," + nrc + "," + dob + "," + gender + "," + accountType + "," + amount+","+accountno+","+password;
        }
        public void deposite(int amt)
        {
            amount = amount + amt;
        }
    }
}
