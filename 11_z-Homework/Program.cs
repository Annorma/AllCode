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

namespace _11_z_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] prods =
            {
                new Product("Play Station 5", 2300, "Games", new DateTime(2021, 12, 19), "USA"),
                new Product("iPhone 11 Pro MAx", 1000, "Technic", new DateTime(2021, 3, 14), "USA"),
                new Product("Game Table", 1000, "Furniture", new DateTime(2017, 6, 3), "China"),
                new Product("Wallet", 160, "Items", new DateTime(2018, 2, 13), "India"),
                new Product("Youtube PC", 3600, "Technic", new DateTime(2021, 5, 5), "UK"),
                new Product("Cookies", 820, "Food", new DateTime(2014, 7, 17), "Ukraine")
            };

            Task1(prods);
            Task2(prods);
            Task3(prods);
            Task4(prods);
            Task5(prods);

          

            WriteLine("\n\nEnd...");
            ReadKey();

        } //--------------------Main--------------------↑


        class Product
        {
            private string name = "";
            private int price = 0;
            private string category = "";
            private string country = "";
            private DateTime productDate;

            public string Name { get => name; }
            public int Price{ get => price; }
            public string Category { get => category; }
            public string Country { get => country; }
            public DateTime ProductDate { get => productDate; }
            
            public Product(string Name, int Price, string Category, DateTime ProductDate, string Country)
            {
                name = Name;
                price = Price;
                productDate = ProductDate;
                category = Category;
                country = Country;
            }
        }

        static void Task1(Product[] prods)
        {
            var rezult = prods.Where(p => p.ProductDate.Year == DateTime.Now.Year).Select(p => p.Name).Distinct();
            WriteLine("-------------[ Task 1 ]-------------");
            ShowCollection(rezult);
        }

        static void Task2(Product[] prods)
        {
            string str = "USA";
            var rezult = prods.Select(p => p.Country == str).Count(p => p);
            WriteLine("-------------[ Task 2 ]-------------");
            WriteLine("\n" + rezult + "\n");
        }

        static void Task3(Product[] prods)
        {
            var max = prods.Max(p => p.Price);
            var min = prods.Min(p => p.Price);
            WriteLine("-------------[ Task 3 ]-------------");
            WriteLine("\n" + max);
            WriteLine(min + "\n");
        }

        static void Task4(Product[] prods)
        {
            var rezult = prods.Where(p => p.Country != "Ukraine").Select(p => p.Category).Distinct();
            WriteLine("-------------[ Task 4 ]-------------");
            ShowCollection(rezult);
        }

        static void Task5(Product[] prods)
        {
            var rezult = prods.GroupBy(p => p.Category).Select(p => p.Count());
            WriteLine("-------------[ Task 5 ]-------------");
            ShowCollection(rezult);
        }

        static void ShowCollection<T>(IEnumerable<T> collection, string text = "")
        {
            WriteLine(text);
            foreach (T item in collection)
            {
                WriteLine(item);
            }
            WriteLine();
        }


    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
