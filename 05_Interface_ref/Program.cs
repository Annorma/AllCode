using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05_Interface_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = Encoding.UTF8;

            //TestWork(new Seller());

            IManager director = new Director
            {
                LastName = "Doe",
                FirstName = "John",
                BirthDate = new DateTime(1998, 10, 12),
                Position = "Director",
                Salary = 12000
            };

            IWorkable seller = new Seller
            {
                LastName = "Beam",
                FirstName = "Jim",
                BirthDate = new DateTime(1956, 5, 23),
                Position = "Seller",
                Salary = 3780
            };

            Console.WriteLine(seller.Work());

            if (seller is Employee)
                Console.WriteLine($"Sellers salary: { (seller as Employee).Salary}");

            // приведение интерфейсной ссылки
            // к классу Employee
            director.ListOfWorkers = new List<IWorkable>
            {
                seller,
                new Cashier
                {
                    LastName = "Smith",
                    FirstName = "Nicole",
                    BirthDate = new DateTime(1956, 5, 23),
                    Position = "Cashier",
                    Salary = 3780
                },
                new Storekeeper
                {
                    LastName = "Ross",
                    FirstName = "Bob",
                    BirthDate = new DateTime(1956, 5, 23),
                    Position = "Storekeeper",
                    Salary = 4500
                }
            };

            Console.WriteLine(director);
            if (director is IManager) // using operator is
            {
                director.Control();
            }

            Console.WriteLine(new string('-', 20));

            foreach (IWorkable item in director.ListOfWorkers)
            {
                if (item is Cashier)
                    Console.WriteLine("Cashier.");

                Console.WriteLine(item);
                if (item.IsWorking)
                {
                    Console.WriteLine(item.Work());
                }
            }

            ////// Multiple Intrfaces
            var admin = new Administrator();

            IManager manager = admin;
            manager.Organize();

            IWorkable worker = admin;
            worker.Work();

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑

        /*
        static void TestWork(IWorkable worker)
        {
            if (worker.IsWorking)
                Console.WriteLine(worker.Work());
            else
                Console.WriteLine("Not working!");
        }

        abstract class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public override string ToString()
            {
                return $"Surname: { LastName}Name: { FirstName} Birthdate: { BirthDate.ToLongDateString()}";
            }
        }
        abstract class Employee : Human
        {
            public string Position { get; set; }
            public double Salary { get; set; }
            public override string ToString()
            {
                return base.ToString() + $"\nPosition: { Position} Salary: { Salary} $";
            }
        }
        interface IWorkable
        {
            bool IsWorking { get; }
            string Work();
        }
        interface IManager
        {
            List<IWorkable> ListOfWorkers { get; set; }
            void Organize();
            void MakeBudget();
            void Control();
        }
        class Director : Employee, IManager // implement (realize)
        {
            public List<IWorkable> ListOfWorkers { get; set; }
            public void Control()
            {
                Console.WriteLine("Controling work...!");
            }
            public void MakeBudget()
            {
                Console.WriteLine("Making budget...!");
            }
            public void Organize()
            {
                Console.WriteLine("Organizing work...!");
            }
        }
        class Seller : Employee, IWorkable
        {
            bool isWorking = true;
            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public string Work()
            {
                return "Selling product!";
            }
        }
        class Cashier : Employee, IWorkable
        {
            bool isWorking = true;
            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public string Work()
            {
                return "Geting pay for product!";
            }
        }

        class Storekeeper : Employee, IWorkable
        {
            private bool _isWorking;
            public bool IsWorking => _isWorking;
            //public bool IsWorking { get { return _isWorking; } }
            public string Work()
            {
                return "Orginize product store...";
            }
        }

        class Administrator : Employee, IWorkable, IManager
        {
            // IWorkable
            public bool IsWorking { get; }
            public string Work()
            {
                return "Administrate smth.";
            }

            // IManager
            public List<IWorkable> ListOfWorkers { get; set; }

            public void Control()
            {
                Console.WriteLine("Controling work...!");
            }
            public void MakeBudget()
            {
                Console.WriteLine("Making budget...!");
            }
            public void Organize()
            {
                Console.WriteLine("Organizing work...!");
            }
        }
        */



    }
}
