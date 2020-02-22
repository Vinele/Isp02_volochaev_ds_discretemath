using System;

namespace Discret01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 27, 38, 24, 35 };
            Sort.Bubble(array);
            Console.WriteLine("Bubble Sort");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int[] array1 = new int[] { 5, 27, 38, 24, 35 };
            Sort.Selection(array1);
            Console.WriteLine("Selection Sort");
            foreach (var i in array1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
