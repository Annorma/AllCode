using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[10];

            FillArray(arr);
            PrintArray(arr);
            SwapElements(arr);
            Console.WriteLine("\n");
            PrintArray(arr);
            int[] rezult = new int[10];

            rezult = Array.FindAll(arr, (x) => x > 0);
            Console.WriteLine("\nAmount of positive numbers: " + rezult.Length);

            int amountOfEven = arr.Count((x) => x % 2 == 0);
            Console.WriteLine("\nAmount of even numbers: " + amountOfEven);

            int firstMultipleOf7 = Array.FindIndex(arr, (x) => x % 7 == 0);
            Console.WriteLine("\nIndex of first number multiple of 7: " + firstMultipleOf7);

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();

            */

        } //--------------------Main--------------------↑

        /*
        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }

        private static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 30);
            }
        }


        private static void SwapElements(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tmp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = tmp;
            }
        }
        */
    }
}
