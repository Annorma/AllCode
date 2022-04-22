using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using static System.Console;

namespace _1_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new[] { 55, -2, 0, 45, 12, 8, 9, 3, 7, 90, 33, -4 };


            // query syntax
            var result = from n in numbers   // from collection
                         where n % 2 == 0    // filter items
                         select Math.Abs(n); // convert each item

            // method syntax
            //numbers.Where(IsEven);
            result = numbers.Where(n => n % 2 == 0).Select(n => Math.Abs(n));

            //ShowCollection(result);

            Student[] group = new[]
            {
                new Student() { Name = "Vova", AverageMark = 9.7F, Birthdate = new DateTime(2002, 2, 15)},
                new Student() { Name = "Igor", AverageMark = 11.2F, Birthdate = new DateTime(2004, 5, 1)},
                new Student() { Name = "Vika", AverageMark = 10.5F, Birthdate = new DateTime(2003, 12, 22)},
                new Student() { Name = "Olga", AverageMark = 10.7F, Birthdate = new DateTime(2004, 9, 2)},
                new Student() { Name = "Mark", AverageMark = 10.0F, Birthdate = new DateTime(2002, 7, 22)},
                new Student() { Name = "Bob", AverageMark = 7.8F, Birthdate = new DateTime(2000, 10, 28)},
            };

            var students = group.Where(s => s.AverageMark >= 10).OrderByDescending(s => s.Name);
            students = from st in @group
                       where st.AverageMark >= 10.5
                       orderby st.Name descending // ascending (default)
                       select st;

            ShowCollection(students);

            var successStudetns = group.OrderByDescending(s => s.AverageMark).Take(3);
            ShowCollection(successStudetns, "Success Students");

            IEnumerable<string> names = group.Select(s => s.Name);
            Console.WriteLine("Names: " + string.Join(", ", names));
            */




            //Task 1

            //year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            /*
            int[] years = new[] { 1990, 2000, 2003, 2015, 1966, 2004, 2020, 2017 };
            var result = years.Where(y => y % 4 == 0 && (y % 100 != 0 || y % 400 == 0));
            ShowCollection(result);

            WriteLine("\n\nEnd...");
            ReadKey();
            */

            //Task 2

            /*
            int[] numbers = new[] { 19, 20, -3, 16, 1, 62, -17, 345, -1456 };
            var result2 = numbers.Where(i => i % 2 == 0).Max();
            WriteLine(result2);

            WriteLine("\n\nEnd...");
            ReadKey();
            */

            //Task 3

            /*
            string[] text = new[] {"Lol", "Lmao", "Really?"};
            var result3 = text.Select(t => t + "!!!");
            ShowCollection(result3);

            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 4

            /*
            List<string> list = new List<string>();
            list.Add("Aboba,");
            list.Add("L.ol");
            list.Add("Lma!o");
            list.Add("?Rainbow,");
            list.Add("?!!!!.Abl");

            var res = new List<string>();

            foreach (var item in list)
            {
                if (item.Contains(","))
                {
                    res.Add(item);
                }
            }

            foreach (var item in res)
            {
                WriteLine(item);
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            */

            //Task 5

            /*
            string str = "Hello everybody, my name is Artem";
            var words = str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var longestWordLenght = words.Max(m => m.Length);
            WriteLine("Longest word: " + words.First(m => m.Length == longestWordLenght));

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑
        static void ShowCollection<T>(IEnumerable<T> collection, string text = null)
        {
            if (text != null) Console.WriteLine(text);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }




        /*
        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        
        class Student
        {
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
            public float AverageMark { get; set; }

            public override string ToString()
            {
                return $"{Name} with mark of {AverageMark} who was borned in {Birthdate.ToShortDateString()}";
            }
        }
        */




    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
