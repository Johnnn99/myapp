using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Players
    {
        private static int gamer1, gamer2;
        public static int FirstGamer
        {
            get
            {
                return gamer1;
            }
            set
            {
                gamer1 = value;
            }
        }
        public static int SecondGamer
        {
            get
            {
                return gamer2;
            }
            set
            {
                gamer2 = value;
            }
        }
    }
}
