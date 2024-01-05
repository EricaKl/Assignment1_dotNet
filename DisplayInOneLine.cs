using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class DisplayInOneLine
    {
        public void Display()
        {
            int x = 10;
            int y= 20;
            int z = 30;

            Console.Write($"Numbers in one line:{x}, {y}, {z}");
        }

        static void Main()
        {
            DisplayInOneLine d = new DisplayInOneLine();
            d.Display();

        }
    }
}
