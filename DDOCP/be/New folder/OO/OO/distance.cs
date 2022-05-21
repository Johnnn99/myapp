using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    public class distance
    {
        private int feet;
        private double inches;

        public distance(int f,double i)
        {
            this.feet=f;
            this.inches=i;
        }
        public distance()
        {
            this.feet=0;
            this.inches=0;
        }
        public int getfeet()
        {
            return feet;
        }
        public void setfeet(int f)
        {
            this.feet=f;
        }
        public double getinches()
        {
            return inches;
        }
        public void setinches(double i)
        {
            this.inches=i;
        }
    }
}
