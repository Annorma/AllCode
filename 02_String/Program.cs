using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _02_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // string - статичні рядки, незмінювані
            // методи по роботі із такими рядками завжди повертають новий об'єкт, а не змінюють існуючий

            //string str = @"Hello\C:\ProgramFiles";
            string str1 = "HELLO";
            string str2 = "hello";

            string str3 = $"{str1} {str2}";
            string str4 = "_Hel   lo, {0}@@@  @@";
            Console.WriteLine(string.Format(str4, "Ira"));

            Console.WriteLine(str1 + str2);
            // str1[0] = '!'; // readonly

            str3 = str1;
            Console.WriteLine(str3);
            Console.WriteLine(str3.Equals(str1, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(str2.Equals(str1));
            Console.WriteLine(object.ReferenceEquals(str3, str1));
            str3 = "Bye";
            Console.WriteLine(str1);
            string test = new string('_', 80);
            Console.WriteLine(str4.ToLower());
            //Console.WriteLine(str4.TrimStart(/_*new[] { '_'}*//*"_".ToCharArray()*_/'_'));
            Console.WriteLine(str4.Trim("_@".ToCharArray()));
            Console.WriteLine(char.IsDigit('g'));
            Console.WriteLine(test);
            Console.WriteLine(str4.StartsWith("_H")); // True
            Console.WriteLine(str4.Contains("lo")); // True
            Console.WriteLine(str4.Replace(" ", ""));
            Console.WriteLine(str4.IndexOf("h", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(test);
            Console.WriteLine(str4.Trim(' ').Split(" ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).Length);

            Console.WriteLine(test);

            Console.WriteLine(str4.Replace(" ", "").Substring(1, 5));
            string[] arr = new[] { "one", "two", "three" };
            Console.WriteLine(string.Join(", ", arr));
            string temp = new string(str1.ToCharArray());
            Console.WriteLine(temp);
            */
        } //--------------------Main--------------------↑
    }
}
