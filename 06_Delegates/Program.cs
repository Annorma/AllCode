using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_Delegates
{
    class Program
    {
        public static void DoOperation(double a, double b, CalcDelegate oper)
        {
            Console.WriteLine(oper.Invoke(a, b));
        }

        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            CalcDelegate delAll = calc.Add; // групповое
                                            // преобразование методов
            delAll += Calculator.Sub; // add element
            delAll += calc.Mult;
            delAll += calc.Div;
            //delAll -= calc.Div; // remove element

            foreach (CalcDelegate item in delAll.GetInvocationList()) // массив делегатов
            {
                try
                {
                    // вызов
                    Console.WriteLine($"{item.Method.Name} - Result: {item(5.7, 1.0)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            DoOperation(100, 2, calc.Div);

            int[] arr = new int[] { 4, 33, 89, 1, 4, 5 };

            ChangeEachElement(arr, Sqr);
            //ChangeEachElement(arr, delegate (int v) { return v * v; }); // anonymous delegate
            //ChangeEachElement(arr, (v) => v * v);                       // lambda expression
            foreach (var i in arr) Console.Write(i + " "); Console.WriteLine();

            ChangeEachElement(arr, Increment);
            foreach (var i in arr) Console.Write(i + " "); Console.WriteLine();


            WriteLine("\n\nEnd...");
            ReadKey();


        } //--------------------Main--------------------↑

    public delegate int ChangeDelegate(int value);

        static int Sqr(int v)
        {
            return v * v;
        }
        static int Increment(int v)
        {
            return ++v;
        }
        static void ChangeEachElement(int[] array, ChangeDelegate algo)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = algo(array[i]);
            }
        }


        public delegate double CalcDelegate(double x, double y);

        public class Calculator
        {
            public double Add(double x, double y)
            {
                return x + y;
            }
            public static double Sub(double x, double y)
            {
                return x - y;
            }
            public double Mult(double x, double y)
            {
                return x * y;
            }
            public double Div(double x, double y)
            {
                if (y != 0)
                {
                    return x / y;
                }
                throw new DivideByZeroException();
            }
        }


    }
}
