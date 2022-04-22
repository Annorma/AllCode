using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _07_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            /*
            ArrayList list = new ArrayList();
            List<int> ilist = new List<int>();
            List<double> dlist = new List<double>();
            List<bool> blist = new List<bool>();
            
            list.Add(true);
            list.Add(21);
            list.Add(6.9);

            foreach (var item in list)
            {
                if (item is bool) { bool a = (bool)item; blist.Add(a); }
                if (item is int) { int a = (int)item; ilist.Add(a); }
                if (item is double) { double a = (double)item; dlist.Add(a); }
            }
            Write("Int list: ");
            foreach (var item in ilist)
            {
                Write(item + "\t");
            }
            Write("\nDouble list: ");
            foreach (var item in dlist)
            {
                Write(item + "\t");
            }
            Write("\nBool list: ");
            foreach (var item in blist)
            {
                Write(item + "\t");
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 2

            /*
            List<string> slist = new List<string>();
            slist.AddRange(new string[] { "Monkey", "Bee", "Unbelivable", "Room", "Doors" });

            string max = "";
            foreach (var item in slist)
            {
                if (item.Length > max.Length ) { max = item; }
            }

            WriteLine("The longest word: " + max);

            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 3

            /*
            var phbook = new PhoneBook();

            WriteLine("---------------- [Add] ---------------");
            phbook.Add(1, "Albert");
            phbook.Add(2, "John");
            phbook.Add(3, "Freddy");
            phbook.Add(4, "Bruce");

            phbook.Show();

            WriteLine("\n--------------- [Edit] ---------------");
            phbook.Edit(3, "Alex");
            phbook.Show();

            WriteLine("\n-------------- [Delete] --------------");
            phbook.Delete(1);
            phbook.Show();

            WriteLine("\n-------------- [Found] ---------------");
            phbook.Found(4);


            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 4






        } //--------------------Main--------------------↑


        /*
        class PhoneBook
        {
            Dictionary<int, PhoneBook> list = new Dictionary<int, PhoneBook>(6);
            public string Name { get; internal set; }
            public override string ToString()
            {
                return $" {Name} ";
            }

            public void Add(int akey, string avalue)
            {
                list.Add(akey, new PhoneBook { Name = avalue });
            }

            public void Show()
            {
                foreach (KeyValuePair<int, PhoneBook> keyValue in list)
                {
                    WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
                }
            }

            public void Edit(int ekey, string evalue)
            {
                if (list.ContainsKey(ekey))
                {
                    list[ekey].Name = evalue;
                }
                else { WriteLine($"There isn't key {ekey}!"); }
            }

            public void Delete(int dkey)
            {
                list.Remove(dkey);
            }

            public void Found(int fkey)
            {
                if (list.ContainsKey(fkey))
                {
                    WriteLine($"{fkey} - {list[fkey].Name}");
                }
                else { WriteLine($"There isn't value with key {fkey}!"); }
            }
        }
        */



    } //--------------------Program--------------------↑
} //--------------------Namespace-------------------↑
