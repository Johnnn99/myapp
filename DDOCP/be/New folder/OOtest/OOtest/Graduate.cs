using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtest
{
   public class Graduate
    {
       private String name;
       private String jobTitle;
       private int salary;

       public Graduate(String n)
       {
           this.name = n;
           this.jobTitle = "jobless";
           this.salary = 0;
       }
       public Graduate(String n,String jt,int s)
       { 
            this.name=n;
            this.jobTitle=jt;
            this.salary=s;
       }  

       public void setName(String n)
       {
            this.name=n;
       }
       public String getName()
       {
           return name;
       }

       public void setjobTitle(String jt)
       {
           this.jobTitle = jt;
       }
        public String getjobTitle()
       {
           return jobTitle;
       }

       public void setsalary(int s)
        {
            this.salary = s;
        }

       public int getsalary()
       {
           return salary;

       }
    }
}
