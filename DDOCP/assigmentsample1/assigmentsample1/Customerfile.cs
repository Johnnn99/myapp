using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentsample1
{
    public class Customerfile
    {
        String accountno, name, phone, password;
        public Customerfile(String ac, String n, String p, String pa)
        {
            this.accountno = ac;
            this.name = n;
            this.phone = p;
            this.password = pa;
        }
        public Customerfile(String bline)
        {
            char[] carr = { ',' };
            String[] sarr=bline.Split(carr);
            this.accountno = sarr[0];
            this.name = sarr[1];
            this.phone = sarr[2];
            this.password = sarr[3];
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
        public void setphone(String p)
        {
            this.phone = p;
        }
        public String getphone()
        {
            return phone;
        }
        public void setpassword(String p)
        {
            this.password = p;
        }
        public String getpassword()
        {
            return password;
        }
        public String getString()
        {
            return accountno + "," + name + "," + phone + "," + password;
        }
    }
}
