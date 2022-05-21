using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni_project_yourname
{
    public class yourname
    {
        private int studentid;
        private String name, major, year, gender, dob, password;

        public yourname(int s, String n, String m, String y, String g, String d, String p)
        {
            this.studentid = s;
            this.name = n;
            this.major = m;
            this.year = y;
            this.gender = g;
            this.dob = d;
            this.password = p;
        }
        public void setstudentid(int s)
        {
            this.studentid = s;
        }
        public int getstudentid()
        {
            return studentid;
        }
        public void setname(String n)
        {
            this.name = n;
        }
        public String getname()
        {
            return name;
        }
        public void setmajor(String m)
        {
            this.major = m;
        }
        public String getmajor()
        {
            return major;
        }
        public void setyear(String y)
        {
            this.year = y;
        }
        public String getyear()
        {
            return year;
        }
        public void setgender(String g)
        {
            this.gender = g;
        }
        public String getgender()
        {
            return gender;
        }
        public void setdob(String d)
        {
            this.dob = d;
        }
        public String getdob()
        {
            return dob;
        }
        public void setpassword(String p)
        {
            this.password = p;
        }
        public String getString()
        {
            return studentid + "," + name + "," + major + "," + year + "," + gender + "," + dob + "," + password;
        }
    }
}
