using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class OperationsDisplay
    {
        public void PerformOpertaion(float x, float y)
        {
            float Add, Sub, Prod, Quot;
           Add = x +y;
           Sub = x - y;
           Prod = x * y;
           Quot = x / y;

            Console.WriteLine("Addition : " + Add);
            Console.WriteLine("Subtraction :" + Sub);
            Console.WriteLine("Product : " + Prod);
            Console.WriteLine("Qout : " +  Quot);

        }


        static void Main()
        {
            Console.WriteLine("Enter First Number");
            float x;
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            float y;
            y = float.Parse(Console.ReadLine());
            OperationsDisplay p = new OperationsDisplay();
            p.PerformOpertaion(x, y);

        }
    }

   
}
