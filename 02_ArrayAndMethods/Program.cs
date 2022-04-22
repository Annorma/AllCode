using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02_ArrayAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            //int[] numbers = null;
            numbers[0] = 34;
            Console.WriteLine(numbers[0]);

            int[] test = new[] { 23, -56, 1 };
            test[1] = int.Parse(Console.ReadLine());

            PrintArray(test);
            */


            /*
            int[] numbers = new int[10];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 100); // генеруємо випадкове число в межах
                                                    // від -10 до 99 включно
            }

            PrintArray(numbers);

            int[] array = new int[10];
            //numbers = numbers.Reverse().ToArray(); // реверс масива
            //PrintArray(numbers);
            Array.Copy(numbers, 5, array, 3, 3); // копіюємо починаючи з 5-ого індекса масиву numbers
                                                 // 3 символа у масив array і вставляємо в позицію 3

            // Array.Sort(numbers, Cmp); // сортуємо масив в порядку зростання
            //Array.Sort(numbers, (x, y) => y - x); // сортуємо масив в порядку спадання,
            // в параметри передаємо компаратор - функцію,
            // яка повертає порядок сортування елементів масива

            //PrintArray(numbers);

            int res = Array.IndexOf(numbers, 0); // поверне -1, якщо елемент не знайдено, інакше індекс першого знайденого елемента
            if (res != -1)
            {
                Console.WriteLine($"Found {res}");
            }
            else
            {
                Console.WriteLine("Nothing was found");
            }

            res = Array.LastIndexOf(numbers, 0); // повертає останній індекс елемента або -1, якщо такого не знайдено
            if (res != -1)
            {
                Console.WriteLine($"Last index of: Found {res}");
            }
            else
            {
                Console.WriteLine("Nothing was found");
            }

            res = Array.FindIndex(numbers, (x) => x % 2 == 0); // поверне індекс першого парного елемента в масиві (або -1)
            if (res != -1)
            {
                Console.WriteLine($"Парний index of: Found {res}");
            }
            else
            {
                Console.WriteLine("Nothing was found");
            }

            int[] elements = Array.FindAll(numbers, (x) => x % 2 == 0); // шукає всі парні елементи
            PrintArray(elements);

            Console.WriteLine(Array.Exists(numbers, (x) => x % 10 == 0)); // перевіряє чи існує у масиві елемент, 
                                                                          // який задовільняє предикат (логічну функцію),
                                                                          // яка вказана другим параметром
            Array.Resize(ref numbers, 8);
            */

        } //--------------------Main--------------------↑

        /*
        private static int Cmp(int x, int y)
        {
            return x - y;
        }

        private static bool IsEvenDigit(int x)
        {
            return x % 2 == 0;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        */

        /*
        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + "\t");
            }


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(element + "\t");
            //}

        Console.WriteLine();
        }*/

        

    }

}

