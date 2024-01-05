using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class DisplayName
    {
        public void ShowName()
        {
            for(int i= 0; i < 10; i++)
            {
                Console.WriteLine("Erica");
            }
        }
        static void Main()
        {
            DisplayName d = new DisplayName();
            d.ShowName();
        }
    }
}
