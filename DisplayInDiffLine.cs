using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class DisplayInDiffLine
    {
        public void Display()
        {
            int x = 10;
            int y = 20;
            int z = 30;

            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(z);
        }

        static void Main()
        {
            DisplayInDiffLine d = new DisplayInDiffLine();
            d.Display();

        }
    }
}
