using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01_z_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------01------------------↓


            //Task 1

            /*
            char input;
            int spaceCount = 0;
            do
            {
                Console.WriteLine("Enter some symbols: ");
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
                Console.Clear();
            }
            while (input != '.');

            Console.WriteLine($"Quantity of spaces: {spaceCount}");

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */


            //Task 2

            /*
            Console.Write("Enter number of ticket (6 numbers): ");

            string sticket = Console.ReadLine();
            if (sticket.Length == 6)
            {

                int ticket = Convert.ToInt32(sticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(sticket)[0].ToString()) + Convert.ToInt32(Convert.ToString(sticket)[1].ToString()) + Convert.ToInt32(Convert.ToString(sticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(sticket)[3].ToString()) + Convert.ToInt32(Convert.ToString(sticket)[4].ToString()) + Convert.ToInt32(Convert.ToString(sticket)[5].ToString())) ? "Ticket is lucky" : "Ticket is not lucky");
            }

            else
            {
                Console.WriteLine("Enter correct ticket number!");
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */


            //Task 3

            /*
            Console.Write("Enter А: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int B = int.Parse(Console.ReadLine());

            if (A >= B || A <= 0 || B <= 0)
            {
                Console.WriteLine("Wrong numbers");
                return;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //Task 4

            /*
            Console.Write("Enter N: ");
            string number = Console.ReadLine();
            if (Convert.ToInt32(number) < 0)
            {
                Console.WriteLine("Number must be >0");
                return;
            }

            Console.Write("Reverse number: ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------01------------------↑


            //----------------02------------------↓

            /*
            int N, m, b, a = 0;
            double hours, minutes;
            Console.Write("Enter amount of hay mowers: ");
            N = Int32.Parse(Console.ReadLine());
            Console.Write("Enter how much time first hay mower worked: ");
            m = Int32.Parse(Console.ReadLine()) * 60;
            for (b = N - 1; b >= 0; b--)
            {
                a = a + b * 10;
            }
            hours = (N * m + a) / 60;
            minutes = (N * m + a) % 60;
            Console.WriteLine($"All brigade worked for {hours} hours {minutes} minutes");

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------02------------------↑
        }
    }
}
