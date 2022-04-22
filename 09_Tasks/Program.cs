using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;
namespace _09_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            
            string writePath = @"drobu.txt";
            string pattern = @"\d+\,\d+|\d*\.\d+";

            string text = File.ReadAllText(writePath, Encoding.Default);

            foreach (var item in Regex.Matches(text, pattern))
            {
                WriteLine($"{item} = {pattern}");
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            


            //Task 2

            
            string writePath1 = @"checkText.txt";

            string text1 = File.ReadAllText(writePath, Encoding.Default);
            string final = Regex.Replace(text1, "fuck|shit|bitch" , "****");

            using (StreamWriter sw = new StreamWriter(writePath1, false, Encoding.Default))
            {
                sw.WriteLine(final);
            }
            //WriteLine(final);

            WriteLine("\n\nEnd...");
            ReadKey();
            


            //Task 3

            
            string writePath2 = @"int.txt";
            string pattern2 = @"\d+";
            List<int> ilist = new List<int>();

            string text2 = File.ReadAllText(writePath2, Encoding.Default);
            foreach (int item in Regex.Matches(text2, pattern2))
            {
                ilist.Add(item);
            }

            foreach (var item in ilist)
            {
                WriteLine(item);
            }

            WriteLine("\n\nEnd...");
            ReadKey();

            

        } //--------------------Main--------------------↑








    }
}
