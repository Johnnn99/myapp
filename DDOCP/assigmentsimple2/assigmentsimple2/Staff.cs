using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentsimple2
{
   public class Staff
     {
        private int id;
        private string name, email, phone, password;

        public Staff(int id, string n, string e, string p, string pass)
        {
            this.id = id;
            this.name = n;
            this.email = e;
            this.phone = p;
            this.password = p;
        }

        public Staff(String line)
        {
            char[] arr = { '/' };
            string[] sarr=line.Split(arr);
            id = Convert.ToInt32(sarr[0]);
            name = sarr[1];
            email = sarr[2];
            phone = sarr[3];
            password = sarr[4];
        }

        public int getid()
        {
            return id;
        }
        public void setid(int id)
        {
            this.id = id;
        }
        public string getname()
        {
            return name;
        }
        public void setname(string n)
        {
            this.name = n;
        }
        public string getemail()
        {
            return email;
        }
        public void setemail(string e)
        {
            this.email = e;
        }
        public string getphone()
        {
            return phone;
        }
        public void setphone(string p)
        {
            this.phone = p;
        }
        public string getpass()
        {
            return password;
        }
        public void setpass(string pass)
        {
            this.password = pass; ;
        }
        public string getstring()
        {
            return id + "/" + name + "/" + email + "/" + phone + "/" + password;
        }
    }
}

   

