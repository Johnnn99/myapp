using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentsample1
{
    public class Staff
    {
        private String id, name, email, password;
        public Staff(string i,string n,string e,string p)
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
            this.id=sarr[0];
            this.name=sarr[1];
            this.email = sarr[2];
            this.password = sarr[3];
        }
        public void setId(String i)
        {
            this.id = i;
        }
        public String getId()
        {
            return id;
        }
         public void setName(String n)
         {
             this.name = n;
         }
         public String getName()
         {
             return name;
         }
         public void setEmail(String e)
         {
             this.email = e;
         }
         public String getEmail()
         {
             return email;
         }
         public void setPassword(String p)
         {
             this.password = p;
         }
         public String getPassword()
         {
             return password;
         }
    }
}
