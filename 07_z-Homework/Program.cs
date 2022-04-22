using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _07_z_Homework
{


    static class MyExtensions
    {
        //----------------01------------------↓

        public static bool IsPalindrome(this string data)
        {
            return data == new string(data.Reverse().ToArray());

        }
        //----------------01------------------↑


        //----------------02------------------↓

        public static string EncodeOrDecode(this string data, int key)
        {
            char[] array = data.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(array[i] ^ key);
            }
            return new string(array);
        }

        //----------------02------------------↑


        //----------------03------------------↓

        public static int NumberOfRepetitions(this int[] arr)
        {
            int numb = arr.Length - arr.Distinct().Count();
            return numb;
        }

        //----------------03------------------↑
    }




    class Program
    {
        static void Main(string[] args)
        {
            //----------------01------------------↓

            
            string str;
            Write("Enter word: ");
            str = ReadLine();
            if (str.IsPalindrome() == true)
            {
                WriteLine("Your word is palindrome...");
            }
            else
            {
                WriteLine("Your word is NOT palindrome...");
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            

            //----------------01------------------↑



            //----------------02------------------↓

            
            const int Key = 33;
            Write("Enter text: ");
            string text = ReadLine();
            string encodedText = text.EncodeOrDecode(Key);
            WriteLine("Encoded text: " + encodedText);
            string decodedText = encodedText.EncodeOrDecode(Key);
            WriteLine("Decoded text: " + decodedText);

            WriteLine("\n\nEnd...");
            ReadKey();
            

            //----------------02------------------↑



            //----------------03------------------↓

            
            int[] arr = {21, 15, 84, 21, 2, 21, 15, 49, 21, 0, 7, 9, 35, 21, 3, 21}; //6 repetitions
            WriteLine($"Number of repetitions: {arr.NumberOfRepetitions()}");

            WriteLine("\n\nEnd...");
            ReadKey();


            //----------------03------------------↑

        } //--------------------Main--------------------↑


    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
