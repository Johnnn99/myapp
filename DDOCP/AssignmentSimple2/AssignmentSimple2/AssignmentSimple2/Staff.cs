using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSimple2
{
    public class Staff
    {
        private int sid;
        private String name, email, phone, password,gender,position;

        public Staff(int sid, String n, String e, String ph, String p,String g,String pos)
        {
            this.sid = sid;
            this.name = n;
            this.email = e;
            this.phone = ph;
            this.password=p;
            this.gender = g;
            this.position = pos;
        }
        public Staff(String line)
        {
            char[] carr = { '/' };
            String[] sarr = line.Split(carr);
            sid = Convert.ToInt32(sarr[0]);
            name = sarr[1];
            email = sarr[2];
            phone = sarr[3];
            password = sarr[4];
            gender = sarr[5];
            position = sarr[6];
        }
        public int getSid()
        {
            return sid;
        }
        public void setSid(int sid)
        {
            this.sid = sid;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String n)
        {
            this.name = n;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String e)
        {
            this.email = e;
        }
        public String getPhone()
        {
            return phone;
        }
        public void setPhone(String ph)
        {
            this.phone = ph;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String p)
        {
            this.password = p;
        }
        public String getGender()
        {
            return gender;
        }
        public void setGender(String g)
        {
            this.gender = g;
        }
        public String getPosition()
        {
            return position;
        }
        public void setPosition(String pos)
        {
            this.position = pos;
        }
        public String getString()
        {
            return sid + "/" + name + "/" + email + "/" + phone + "/" + password + "/" + gender + "/" + position;
        }
    }
}
