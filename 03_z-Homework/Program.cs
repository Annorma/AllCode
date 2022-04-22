using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _03_z_Homework
{
    class Program
    {
		static void Main(string[] args)
		{
			//----------------01------------------↓
			#region 01
			/*
			Rectangle rectangle = new Rectangle(4, 2);
			Console.WriteLine("Rectangle: " + rectangle);
			Console.WriteLine("[++] operator: " + rectangle++);
			Console.WriteLine("[--] operator: " + rectangle--);
			Console.WriteLine("[*] operator: " + rectangle * 2);
			Console.Write("[true/false] operator: ");

			if (rectangle)
				Console.WriteLine("TRUE");
			else
				Console.WriteLine("FALSE");

			Rectangle rectangle2 = new Rectangle(4, 2);
			Console.WriteLine("\n\nRectangle 1 : " + rectangle);
			Console.WriteLine("Rectangle 2 : " + rectangle2);
			Console.WriteLine("Equels: " + rectangle.Equals(rectangle2));

			Console.WriteLine("\n\n-----------------------------------\n\n");

			Square square = new Square(4);
			Console.WriteLine("Square: " + square);
			Console.WriteLine("[++] operator: " + square++);
			Console.WriteLine("[--] operator: " + square--);
			Console.WriteLine("[*] operator: " + square * 2);
			Console.Write("[true/false] operator: ");

			if (square)
				Console.WriteLine("TRUE");
			else
				Console.WriteLine("FALSE");

			Square square2 = new Square(5);
			Console.WriteLine("\n\nSquare 1 : " + square);
			Console.WriteLine("Square 2 : " + square2);
			Console.WriteLine("Equels: " + square.Equals(square2));

			Console.WriteLine("\n\nEnd...");
			Console.ReadKey();
			*/
			#endregion
			//----------------01------------------↑



			//----------------02------------------↓

			/*
			Factory factory = new Factory("McDonalds");
			factory.ShowEmployee();
			factory.ShowProducts();

            WriteLine($"\n\nEmployee count: {factory.EmpCount()} people");
            WriteLine($"Average salary: ${factory.AvgSalary()}");
            WriteLine($"GDP: ${factory.GDP()}");
            WriteLine($"Total salary: ${factory.TotalSalary()}");


			WriteLine("\n\nEnd...");
			ReadKey();
			*/

			//----------------02------------------↑


		} //--------------------Main--------------------↑

		//----------------01------------------↓
		/*

		class Rectangle
		{
			private int a;
			private int b;

			public Rectangle() { }
			public Rectangle(int a, int b)
			{
				this.a = (a >= 0 ? a : 0);
				this.b = (b >= 0 ? b : 0);
			}

			public override bool Equals(object obj)
			{
				return obj is Rectangle rectangle &&
					   a == rectangle.a &&
					   b == rectangle.b;
			}

			public override int GetHashCode()
			{
				int hashCode = 2118541809;
				hashCode = hashCode * -1521134295 + a.GetHashCode();
				hashCode = hashCode * -1521134295 + b.GetHashCode();
				return hashCode;
			}

			public override string ToString()
			{
				return $"Rectangle: a = {a}cm, b = {b}cm";
			}
			public static Rectangle operator ++(Rectangle r)
			{
				r.a++;
				r.b++;
				return r;
			}
			public static Rectangle operator --(Rectangle r)
			{
				r.a--;
				r.b--;
				return r;
			}
			public static Rectangle operator *(Rectangle r, int n)
			{
				Rectangle r2 = new Rectangle
				{
					a = r.a * n,
					b = r.b * n
				};
				return r2;
			}
			public static bool operator true(Rectangle r)
			{
				return r.a != 0 || r.b != 0;
			}
			public static bool operator false(Rectangle r)
			{
				return r.a == 0 && r.b == 0;
			}
			public static explicit operator int(Rectangle r)
			{
				return r.a + r.b;
			}
			public static implicit operator Square(Rectangle r)
			{
				return new Square(r.a);
			}
		}

		class Square
		{
			private int a;

			public Square() { }
			public Square(int a) { this.a = (a >= 0 ? a : 0); }

			public override bool Equals(object obj)
			{
				return obj is Square square &&
					   a == square.a;
			}

			public override int GetHashCode()
			{
				return -1757793268 + a.GetHashCode();
			}

			public override string ToString()
			{
				return $"Square: a = {a}cm";
			}
			public static Square operator ++(Square s)
			{
				s.a++;
				return s;
			}
			public static Square operator --(Square s)
			{
				s.a--;
				return s;
			}
			public static Square operator *(Square s, int n)
			{
				Square s2 = new Square
				{
					a = s.a * n
				};
				return s2;
			}
			public static bool operator true(Square s)
			{
				return s.a != 0;
			}
			public static bool operator false(Square s)
			{
				return s.a == 0;
			}
			public static explicit operator int(Square s)
			{
				return s.a;
			}
			public static implicit operator Rectangle(Square s)
			{
				return new Rectangle(s.a, 0);
			}
		}
		*/

		//----------------01------------------↑



		//----------------02------------------↓

		/*
		class Factory
		{
			private string fname;
			Employee[] employee = new Employee[5]
			{
				new Employee("John", "Lenon", new DateTime(1980,11,21), 3200),
				new Employee("Adam", "McCortnee", new DateTime(1983,5,3), 2600),
				new Employee("Brian", "Oconor", new DateTime(1992,12,13), 2800),
				new Employee("Bucky", "Burns", new DateTime(1984,8,17), 3000),
				new Employee("Bruce", "Wayne", new DateTime(1982,2,24), 3450)
			};
			Product[] products = new Product[7]
			{
				new Product("BigMac", new DateTime(2021,9,30), 13),
				new Product("FishBurger", new DateTime(2021,9,30), 16),
				new Product("ChickenBurger", new DateTime(2021,9,30), 15),
				new Product("BigTasty", new DateTime(2021,9,30), 14),
				new Product("Nuggets", new DateTime(2021,9,30), 12),
				new Product("Cola", new DateTime(2021,9,30), 10),
				new Product("Pepsi", new DateTime(2021,9,30), 10)
			};
			public Factory() { }
			public Factory(string name)
			{
				fname = (name != null ? name : "");
			}

            public string Fname { get; set; }
			public decimal AvgSalary()
			{
				decimal sum = 0;
				decimal rez = 0;
				for (int i = 0; i < employee.Length; i++)
				{
					sum += employee[i].Salary;
				}
				rez = sum / employee.Length;
				return rez;
			}

			public decimal TotalSalary()
			{
				decimal sum = 0;
				for (int i = 0; i < employee.Length; i++)
				{
					sum += employee[i].Salary;
				}
				return sum;
			}

			public decimal GDP()
			{
				decimal sum = 0;
				decimal rez = 0;
				for (int i = 0; i < products.Length; i++)
				{
					sum += products[i].Price;
				}
				rez = sum / employee.Length;
				return rez;
			}

			public int EmpCount()
			{
				int rez = 0;
				rez = employee.Length;
				return rez;
			}

			public void ShowEmployee()
			{
                WriteLine("---------------[ Employee list]---------------\n");
                for (int i = 0; i < employee.Length; i++)
                {
                    WriteLine($"№{i + 1} {employee[i].Name} {employee[i].Surname} {employee[i].BirthDate} - ${employee[i].Salary}");
                }
			}
			public void ShowProducts()
			{
				WriteLine("\n\n---------------[ Product list] ---------------\n");
				for (int i = 0; i < products.Length; i++)
				{
					WriteLine($"({products[i].DateOfManufacture}) №{i + 1} {products[i].Pname} - ${products[i].Price} ");
				}
			}
		}

		class Employee
		{
			private string name;
			private string surname;
			private string birthDate;
			private decimal salary;

			public Employee() { }
			public Employee(string name, string surname, DateTime birthDate, decimal salary)
			{
				this.name = name;
				this.surname = surname;
				this.birthDate = birthDate.ToString("dd.MM.yyyy");
				this.salary = salary;
			}

			public string Name { get => name; }
			public string Surname { get => surname; }
			public string BirthDate { get => birthDate; }
			public decimal Salary { get => salary; }
			public override string ToString()
			{
				return $"{name} {surname} {birthDate} - ${salary}";
			}
		}

		class Product
		{
			private string pname;
			private readonly string dateOfManufacture;
			private decimal price;

			public Product() { }
			public Product(string name, DateTime dateOfManufacture, decimal price)
			{
				this.pname = name;
				this.dateOfManufacture = dateOfManufacture.ToString("dd.MM.yyyy"); ;
				this.price = price;
			}

			public string Pname { get => pname; }
			public string DateOfManufacture { get => dateOfManufacture; }
			public decimal Price { get => price; }
			public override string ToString()
			{
				return $"{dateOfManufacture} № {pname} - ${price}";
			}
		}
		*/

		//----------------02------------------↑
	}
}
