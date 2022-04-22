using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02_z_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------01------------------↓

            /*
            Random rand = new Random();
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            FillArray(arr1, rand);
            Console.Write("\nArr 1: ");
            PrintArray(arr1);

            FillArray(arr2, rand);
            Console.Write("\nArr 2: ");
            PrintArray(arr2);

            int povtor = 0;
            int index_3 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        for (int k = 0; k < arr3.Length; k++)
                        {
                            if (arr3[k] == arr2[j])
                            {
                                povtor++;
                            }
                        }
                        if (povtor == 0)
                        {
                            arr3[index_3] = arr2[j];
                            index_3++;
                        }
                        povtor = 0;
                    }
                }
            }

            Console.Write("\nArr 3: ");
            PrintArray(arr3);
            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------01------------------↑



            //----------------02------------------↓

            /*
            string str;
            Console.Write("Enter word: ");
            str = Console.ReadLine();
            if (IsPalindrome(str) == true)
            {
                Console.WriteLine("Your word is palindrome...");
            }
            else
            {
                Console.WriteLine("Your word is NOT palindrome...");
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------02------------------↑



            //----------------03------------------↓

            /*
            Console.Write("Enter text: ");
            string str = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(str);
            string[] strArr = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Amount of words: " + strArr.Length);

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------03------------------↑



            //----------------04------------------↓

            /*
            Random rand = new Random();
            int[,] matrix = new int[5, 5];
            int sum = 0, max = matrix[0, 0], min = matrix[0, 0];
            int ni = 0, mj = 0, ki = 0, lj = 0;
            bool count = false;
            try
            {
                Console.WriteLine("Array 5x5: ");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(-100, 100);
                        if (max < matrix[i, j])
                        {
                            max = matrix[i, j];
                            ni = i;
                            mj = j;
                        }
                        if (min > matrix[i, j])
                        {
                            min = matrix[i, j];
                            ki = i;
                            lj = j;
                        }
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if ((i == ni && j == mj) || (i == ki && j == lj))
                        {
                            if (count)
                            {
                                count = false;
                                continue;
                            }
                            else
                            {
                                count = true;
                                continue;
                            }
                        }
                        if (count)
                        {
                            sum += matrix[i, j];
                            Console.Write(matrix[i, j] + " + ");
                        }
                    }
                }

                Console.WriteLine();

                Console.WriteLine($"Max = {max} [{ mj + 1}, {ni + 1}]");
                Console.WriteLine($"Min = {min} [{lj + 1}, {ki + 1}]");
                Console.WriteLine($"Sum = {sum}");
            }
            catch (Exception)
            {
                Console.WriteLine("End of programe");
                Environment.Exit(0);
            }


            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            

            //----------------04------------------↑




            //--------------------String--------------------↓




            //----------------01------------------↓

            /*
            Console.Write("Enter words: ");
            string str = Console.ReadLine();
            Console.WriteLine("Longest word: " + LongestWord(str));
            Console.WriteLine("Shortest word: " + ShortestWord(str));

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------01------------------↑



            //----------------02------------------↓

            /*
            Console.Write("Enter text: ");
            string str = Console.ReadLine();
            Console.Write("Enter symbol: ");
            string symbol = Console.ReadLine();

            string rezult = str.Remove(str.LastIndexOf(symbol) + 1);
            rezult = rezult.Replace(symbol, symbol.ToUpper());
            Console.WriteLine("Rezult: " + rezult);

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------02------------------↑



            //----------------03------------------↓

            /*
            const int Key = 33;
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            string encodedText = EncodeOrDecode(text, Key);
            Console.WriteLine("Encoded text: " + encodedText);
            string decodedText = EncodeOrDecode(encodedText, Key);
            Console.WriteLine("Decoded text: " + decodedText);
            
            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------03------------------↑



            //----------------04------------------↓

            /*
            string text = "Here is a lot of text for helping works this programe";

            var frequencies = ToFrequencyDictionary(text);

            foreach (var item in frequencies)
            {
                Console.WriteLine($"'{item.Key}' - {item.Value}");
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
            */

            //----------------04------------------↑



        } //--------------------Main--------------------↑



        //----------------01------------------↓

        /*
        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                if(element != 0)
                    Console.Write(element + " ");
            }
        }

        private static void FillArray(int[] array, Random rand)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 60);
            }
        }
        */

        //----------------01------------------↑



        //----------------02------------------↓

        /*
        static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }
        */

        //----------------02------------------↑




        //--------------------String--------------------↓




        //----------------01------------------↓

        /*
        private static string LongestWord(string str)
        {
            if (str.EndsWith("."))
            {
                str = str.Substring(0, str.Length - 1);
            }

            var words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var longestWordLenght = words.Max(m => m.Length);
            return words.First(m => m.Length == longestWordLenght);
        }

        private static string ShortestWord(string str)
        {
            if (str.EndsWith("."))
            {
                str = str.Substring(0, str.Length - 1);
            }

            var words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var shortestWordLenght = words.Min(m => m.Length);
            return words.First(m => m.Length == shortestWordLenght);
        }
        */

        //----------------01------------------↑



        //----------------03------------------↓

        /*
        private static string EncodeOrDecode(string text, int key)
        {
            char[] array = text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(array[i] ^ key);
            }
            return new string(array);
        }
        */

        //----------------03------------------↑



        //----------------04------------------↓

        /*
        static Dictionary<char, int> ToFrequencyDictionary(string source)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var symbol in source)
            {
                if (result.ContainsKey(symbol))
                    result[symbol]++;
                else
                    result[symbol] = 1;
            }

            return result;
        }
        */

        //----------------04------------------↑

    }
}
