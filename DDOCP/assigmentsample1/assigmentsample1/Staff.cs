using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentsample1
{
    public class Staff
    {
        private String id, name, email, password;
        public Staff(String i,String n,String e,String p)
        {
            this.id = i;
            this.name = n;
            this.email = e;
            this.password = p;
        }
        public Staff(String line)
        {
            char[] carr = { ',' };
            String[] sarr=line.Split(carr);
            this.id = sarr[0];
            this.name = sarr[1];
            this.email = sarr[2];
            this.password = sarr[3];
        }
        public void setid(String i)
        {
            this.id = i;
        }
        public String getid()
        {
            return id;
        }
        public void setname(String n)
        {
            this.name = n;
        }
        public String getname()
        {
            return name;
        }
        public void setemail(String e)
        {
            this.email = e;
        }
        public String getemail()
        {
            return email;
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
            return id + "," + name + "," + email + "," + password;
        }
    }
}
