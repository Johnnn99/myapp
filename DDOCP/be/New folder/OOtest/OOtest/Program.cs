using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtest

{
    class Program
    {
        static void Main(string[] args)
        {
            Graduate g1 = new Graduate("Mg Mg", "Programmer", 300000);
            Console.WriteLine("Name = " + g1.getName());
            Console.WriteLine("JobTitle = " + g1.getjobTitle());
            Console.WriteLine("Salary = " + g1.getsalary());
            g1.setsalary(380000);
            Console.WriteLine("Salary with bonus =" + g1.getsalary());

            Graduate g2 = new Graduate("Su Su");
            Console.WriteLine("Name = " + g2.getName());
            Console.WriteLine("JobTitle =" + g2.getjobTitle());
            Console.WriteLine("Salary = " + g2.getsalary());

            g2.setjobTitle("Web Developer");
            g2.setsalary(250000);
            Console.WriteLine("After have a job");
            Console.WriteLine("Name = " + g2.getName());
            Console.WriteLine("JobTitle = " + g2.getjobTitle());
            Console.WriteLine("Salary = " + g2.getsalary());

            Console.ReadKey();
        }
    }
}
