using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01_CsharpStart
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------Class Work------------------↓

            /*
            Console.WriteLine("Hello World!");

            int intV = 10;
            short shortV = 20;
            bool boolV = true;
            float floatV = 5.6f;
            double dlobleV = 2.5;
            decimal decimalV = 30000.50m;
            char charV = '@'; // 2 bytes

            object obj = new object();
            Console.WriteLine(obj.ToString());

            string name = "Artem";
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"Hello,  {name}  !"); //interpolation

            DateTime newyear = new DateTime(2022, 1, 1);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Слава Україні");

            int a = 5;
            
            //Nullable<int> b = null;
            int? b = null;

            string str = "some text";
            string str2 = str;

            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            //int number = Convert.ToInt32(num);
            int number = int.Parse(num);

            Console.WriteLine($"Next number: {++number}");

            Console.ReadKey();
            */


            /*
            // value-type: int, char, double, float, struct
            // reference-type: Array, string, class

            //int? test = null;
            int[] numbers = new int[5];
            numbers[0] = 34;
            Console.WriteLine(numbers[0]);

            int[] test = new[] { 23, -56, 1 };
            //   test[1] = int.Parse(Console.ReadLine());

            PrintArray(test);

            // test[3] = 12; // error

            int[] array = new int[10];

            test.CopyTo(array, 0);   // Copy elements from 0 index of test to array
            PrintArray(array);

            Console.WriteLine();
            MultipleElements(test);
            PrintArray(test);

            int[] b = test; // копіюємо посилання, тепер b та test вказують на одну область в пам'яті
            b[0] = 9;
            Console.WriteLine("b.Equals(test): " + b.Equals(test)); // true
            Console.WriteLine("b.ReferenceEquals(test): " + object.ReferenceEquals(b, test)); // true
            PrintArray(b);
            PrintArray(test);

            int a = 12;
            int c = 23;
            Console.WriteLine(a == c); // false
            Console.WriteLine("a.Equals(c): " + a.Equals(c)); // false
            a = c; // 23
            //a = 100;
            Console.WriteLine("a.Equals(c): " + a.Equals(c)); // true
            Console.WriteLine("a.Equals(c): " + object.ReferenceEquals(a, c)); // false
            Console.WriteLine();

            int count = 0;
            // ref - передача аргумента за посиланням
            // out - вихідні параметри, через такі параметри можна "повернути" значення із метода
            // якщо вказано біля параметра метода, то обов'язково вказувати і при виклику метода
            ReverseArray(ref test, out count);
            Console.WriteLine($"Count = {count}");
            PrintArray(test);
            */

        } //--------------------Main--------------------↑

        /*
        private static void ReverseArray(ref int[] test, out int count)
        {
            var temp = test.Length - 1;
            int[] array = new int[test.Length];
            for (int i = 0; i < test.Length; i++)
            {
                array[temp--] = test[i];
            }

            test = array;
            count = test.Length * 10; // тест: перевіряли, як працює out-параметр
        }

        private static void MultipleElements(int[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                test[i] *= 2;
            }
        }

        private static void PrintArray(int[] array)
        {
            foreach (int element in array) // element у foreach циклі == array[i] у for-циклі
            {
                // element = -99999; // readonly - цикл - тільки для читання
                Console.Write(element + "\t"); // array[i]
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = -99999;
            //    Console.Write(array[i] + "\t");
            //}

            Console.WriteLine();
        }
        */


        //----------------Class Work------------------↑
    }
    
}
