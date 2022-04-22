using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            Shop shop = new Shop(3);
            Laptop elem = shop[0];
            Console.WriteLine(elem);

            shop[0] = new Laptop
            {
                Vendor = "Samsung",
                Price = 5200
            };
            shop[1] = new Laptop
            {
                Vendor = "Asus",
                Price = 4700
            };
            shop[2] = new Laptop
            {
                Vendor = "LG",
                Price = 4300
            };

            try
            {
                for (int i = 0; i < shop.Length; i++)
                {
                    WriteLine(shop[i]);
                }
                WriteLine();
                WriteLine($"Vendor Asus: { shop["Asus"] }.");
                WriteLine($"Vendor HP: { shop["HP"] }.");

                // ignore
                shop["HP"] = new Laptop();

                WriteLine($"Price 4300: { shop[4300.0] }.");
                // incorrect price
                WriteLine($"Price 10500: { shop[10500.0] }.");
                // ignore
                shop[10500.0] = new Laptop();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();

        } //--------------------Main--------------------↑


        public class Laptop
        {
            public string Vendor { get; set; }
            public double Price { get; set; }
            public override string ToString()
            {
                return $"{Vendor} {Price}";
            }
        }
        //enum Vendors { Samsung, Asus, LG };
        public class Shop
        {
            private Laptop[] laptopArr;
            public Shop(int size)
            {
                laptopArr = new Laptop[size];
            }
            public int Length
            {
                get { return laptopArr.Length; }
            }
            public Laptop this[int index]
            {
                get
                {
                    if (index >= 0 && index < laptopArr.Length)
                    {
                        return laptopArr[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    laptopArr[index] = value;
                }
            }
            public Laptop this[string name]
            {
                get
                {
                    foreach (var item in laptopArr)
                    {
                        if (item.Vendor == name)
                            return item;
                    }
                    return null;
                    //if (Enum.IsDefined(typeof(Vendors), name))
                    //{
                    //    return laptopArr[(int)Enum.Parse(typeof(Vendors), name)];
                    //}
                    //else
                    //{
                    //    return new Laptop();
                    //}
                }
                set
                {
                    //if (Enum.IsDefined(typeof(Vendors), name))
                    //{
                    //    laptopArr[(int)Enum.Parse(typeof(Vendors), name)] = value;
                    //}

                    for (int i = 0; i < laptopArr.Length; i++)
                    {
                        if (laptopArr[i].Vendor == name)
                        {
                            laptopArr[i] = value;
                            break;
                        }
                    }
                }
            }

            public int FindByPrice(double price)
            {
                for (int i = 0; i < laptopArr.Length; i++)
                {
                    if (laptopArr[i].Price == price)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public Laptop this[double price]
            {
                get
                {
                    int index = FindByPrice(price);
                    if (index != -1)
                    {
                        return laptopArr[index];
                    }
                    throw new Exception("Incorrect price.");
                }
                set
                {
                    int index = FindByPrice(price);
                    if (index != -1)
                    {
                        this[index] = value;
                    }
                }
            }
        }

    }
}
