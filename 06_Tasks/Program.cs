using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_Tasks
{
    class Program
    {

        static void Sqrt(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                Write(i * i + " ");
            }
        }

        static void Factorial(int limit)
        {
            int factorial = 1;
            for (int i = 2; i <= limit; i++)
            {
                factorial = factorial * i;
                Write(factorial + " ");
            }
        }
        static void Main(string[] args)
        {
            SuperCounter sup = new SuperCounter();
            sup.Calculate(10);


            WriteLine("\n\nEnd...");
            ReadKey();


        } //--------------------Main--------------------↑

        public delegate void Algoritm(int value);

        public class SuperCounter
        {
            private Algoritm algo;

            public SuperCounter()
            { 
                algo = delegate (int v)
                {
                    for (int i = 0; i <= v; i++)
                    {
                        Write(i + " ");
                    }
                };
            }
            public SuperCounter(Algoritm value)
            {
                algo = value;
            }
            public void Calculate(int limit)
            {
                algo?.Invoke(limit);
            }


        }



    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
