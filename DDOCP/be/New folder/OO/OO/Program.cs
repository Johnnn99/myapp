using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Distance d1 = new Distance(4, 5);
            Console.WriteLine(d1.getFeet() + "\'" +
                d1.getInches() + "\"");
            Distance d2 = new Distance(4, 8);
            Console.WriteLine(d2.getFeet() + "\'" +
                d2.getInches() + "\"");
            Distance ans = new Distance(d1.getFeet()
                + d2.getFeet(), d1.getInches + d2.getInches());
            if(ans.getInches()>=12)
            {
                ans.setInches(ans.getInches() - 12);
                ans.setFeet(ans.getFeet() + 1);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(ans.getFeet() + "\'" +
               ans.getInches() + "\"");*/
            distance f1 = new distance(5, 3);
            Console.WriteLine(f1.getfeet() + "\'" + f1.getinches() + "\"");
            distance f2 = new distance(4, 8);
            Console.WriteLine(f2.getfeet() + "\'" + f2.getinches() + "\"");
            distance ans = new distance(f1.getfeet() + f2.getfeet(), f1.getinches() + f2.getinches());
            if(ans.getinches()<0)
            {
                ans.setinches(ans.getinches() + 12);
                ans.setfeet(ans.getfeet() - 1);
            }
             Console.WriteLine("-------------");
            Console.WriteLine(ans.getfeet() + "\'" +
               ans.getinches() + "\"");
            Console.ReadKey();
        }
    }
}
