using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class OperationDisplayAsPerChoice
    {

        public void OperationsPerform(float x, float y, string choice)
        {
            float Add, Sub, Prod, Quot;
            switch (choice)
            {
                case "+":
                    {
                        Add = x + y;
                        Console.WriteLine($"Addition is :{Add}");
                        break;
                    }
                case "-":
                    {
                        Sub = x - y;
                        Console.WriteLine($"Subtraction is :{Sub}");
                        break;
                    }
                case "*":
                    {
                        Prod = x * y;
                        Console.WriteLine($"Product is :{Prod}");
                        break;
                    }
                case "/":
                    {
                        Quot = x / y;
                        Console.WriteLine($"Quotient is :{Quot}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }

            }

        }

        static void Main()
        {
            float x, y;
            string choice;
            string ch;
            do
            {
                Console.WriteLine("Enter First Number");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                y = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your choice to perform operation  ");
                Console.WriteLine(" + - * /");
                choice = Console.ReadLine();
                OperationDisplayAsPerChoice op = new OperationDisplayAsPerChoice();
                op.OperationsPerform(x, y, choice);
                Console.WriteLine("Do you wish to perform again (y/N)");
                ch = Console.ReadLine();
            }
            while (ch == "y"|| ch =="Y");
          

        }
    }
}
