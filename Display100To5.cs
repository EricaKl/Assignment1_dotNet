using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class Display100To5
    {
        public void Display()
        {
            for(int i=100; i>1; i-=3)
            {
                Console.WriteLine($"Numbers 100 to 5 with gap of 3 as follows:{i}");
            }
        }

        static void Main()
        {
            Display100To5 d = new Display100To5();
            d.Display();
        }
    }
}
