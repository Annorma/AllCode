using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] matrix = null; // 2-вимірний масив

            Console.WriteLine("Please enter rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter cols");
            int col = int.Parse(Console.ReadLine());

            matrix = new int[row, col];

            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++) // rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // cols
                {
                    matrix[i, j] = rand.Next(10); // 0..1
                    Console.Write($"{matrix[i, j]:N3}  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] jugedArray = new int[3][]; // "зубчаті" або рвані масиви, масиви масивів
            for (int i = 0; i < jugedArray.Length; i++)
            {
                jugedArray[i] = new int[rand.Next(10) + 1];

                for (int j = 0; j < jugedArray[i].Length; j++)
                {
                    jugedArray[i][j] = rand.Next(20);
                }

                PrintArray(jugedArray[i]);
            }
            */

        } //--------------------Main--------------------↑

        /*
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
    }
}
