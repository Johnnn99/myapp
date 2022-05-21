using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentsample1
{
    public class Account
    {
         private String accountno, name, nrc, phone, dob, password;
         private double amount;
        public Account(String ac,String n,String nr,String p,String d,String pa,double a)
        {
            this.accountno = ac;
            this.name = n;
            this.nrc = nr;
            this.phone=p;
            this.dob=d;
            this.password = pa;
            this.amount=a;
        }
        public Account(String line)
        {
            char[] carr = { ';' };
            String[] sarr=line.Split(carr);
            this.accountno = sarr[0];
            this.name = sarr[1];
            this.nrc = sarr[2];
            this.phone = sarr[3];
            this.dob = sarr[4];
            this.password = sarr[5];
            this.amount = Convert.ToDouble(sarr[6]);
        }
        public void setaccountno(String ac)
        {
            this.accountno = ac;
        }
        public String getaccountno()
        {
            return accountno;
        }
        public void setname(String n)
        {
            this.name = n;
        }
        public String getname()
        {
            return name;
        }
        public void setnrc(String nr)
        {
            this.nrc = nr;
        }
        public String getnrc()
        {
            return nrc;
        }
        public void setphone(String p)
        {
            this.phone = p;
        }
        public String getphone()
        {
            return phone;
        }
        public void setdob(String d)
        {
            this.dob = d;
        }
        public String getdob()
        {
            return dob;
        }
        public void setpassword(String pa)
        {
            this.password = pa;
        }
        public String getpassword()
        {
            return password;
        }
        public void setamount(double a)
        {
            this.amount = a;
        }
        public double getamount()
        {
            return amount;
        }
        public String getString()
        {
            return accountno + ";" + name + ";" + nrc + ";" + phone + ";" + dob + ";" + password + ";" + amount;
        }
    }
}
