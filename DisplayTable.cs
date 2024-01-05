using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1_Assign1
{
    internal class DisplayTable
    {
        public void ForLooop(int number, int size)
        {
            Console.WriteLine("Using For Loop");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{number} x {i + 1} = {number * (i + 1)}");
            }

        }

        public void DoWhileLoop(int number, int size)
        {
            int i = 0;
            Console.WriteLine("Using Do Loop");
            do
            {
                Console.WriteLine($"{number} x {i + 1} = {number * (i + 1)}");
                i++;
            } while (i < size);
         

        }

        public void WhileLoop(int number, int size)
        {
            int i = 0;
            Console.WriteLine("Uisng While Loop");
            while (i < size)
            {
                Console.WriteLine($"{number} x {i + 1} = {number * (i + 1)}");
                i++;
            }
           
        }

        static void Main()
        {
            int number;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            int size;
            Console.WriteLine("Enter size of table");
            size = int.Parse(Console.ReadLine());


            DisplayTable p = new DisplayTable();
            p.ForLooop(number, size);
            p.WhileLoop(number, size);
            p.DoWhileLoop(number, size);
        }

    }
}
