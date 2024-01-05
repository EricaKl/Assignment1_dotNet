using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign1
{
    internal class Loop2Perform
    {
        public void ForLooop(int[] arr, int size)
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result.Add(arr[i]);
                }
            }
            Console.WriteLine("Using For Loop");
            Console.WriteLine("All Odd Numbers are ");
            foreach (int obj in result)
            { Console.WriteLine(obj); }
            //Console.WriteLine(result);

        }

        public void DoWhileLoop(int[] arr, int size)
        {
            int i = 0;
            //int[] result = [];
            ArrayList result = new ArrayList();
            do
            {
                if (arr[i] % 2 != 0)
                {
                    result.Add(arr[i]);
                }
                i++;
            } while (i < size);
            Console.WriteLine("Using Do While Loop");
            Console.WriteLine("All Odd Numbers are ");
            foreach (int obj in result)
            { Console.WriteLine(obj); }
            //Console.WriteLine(result);

        }

        public void WhileLoop(int[] arr, int size)
        {
            int i = 0;
            ArrayList result = new ArrayList();
            while (i < size)
            {
                if (arr[i] % 2 != 0)
                {
                    result.Add(arr[i]);
                }
                i++;
            }
            Console.WriteLine("Using While Loop");
            Console.WriteLine("All Odd Numbers are ");
            foreach (int obj in result)
            { Console.WriteLine(obj); }
            //Console.WriteLine(result);
        }

        static void Main()
        {

            int size;
            Console.WriteLine("Enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < size; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Loop2Perform p = new Loop2Perform();
            p.ForLooop(arr, size);
            p.WhileLoop(arr, size);
            p.DoWhileLoop(arr, size);
        }

    }
}
