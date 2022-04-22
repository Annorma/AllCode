using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _03_Tasks
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
				Freezer freezer = new Freezer("Samsung", 5, 175);
				freezer.ShowInfo();
                Console.WriteLine(freezer);
				freezer.TestFreezer();

				const int SIZE = 5;
				Freezer[] arr = new Freezer[SIZE]
				{
					new Freezer("Xiaomi", 6, 200), new Freezer("Apple", 4, 150), new Freezer("Lenovo", 5, 120), new Freezer("Samsug", 5, 175), new Freezer("Sonic", 2, 220)
				};
				freezer.ShowFreezers(SIZE, arr);

				Console.WriteLine("\n\nEnd...");
				Console.ReadKey();
				*/


			//Task 2

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


			Console.WriteLine("\n\n---------------------------\n\n");
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

		} //--------------------Main--------------------↑

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
					a = r.a * n, b = r.b * n
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

			



		/*
		class Freezer
		{
			private string model;
			private int temperature;
			private int capacity;
			private readonly int manufactureYear = 2018;
		
			private static int count;
			static Freezer() { count = 666; }
			public Freezer() { }
			public Freezer(string model, int temperature, int capacity)
			{
				this.model = model;
				this.temperature = temperature;
				this.capacity = capacity;
			}
		
			public int Temperature
			{
				get => temperature;
				set => temperature = (value >= 0 ? value : 0);
			}
			
			public int ManufactureYear { get => manufactureYear; }
			public string Model { get => model; }
			public int Capacity { get => capacity; }
			public int Age => DateTime.Now.Year - ManufactureYear;
			public void ShowFreezers(int size, Freezer[] arr)
			{
				for (int i = 0; i < size; i++)
				{
					Console.WriteLine($"-------------- Freezer [{arr[i].Model}] --------------");
					Console.WriteLine($"Temperature: +{arr[i].Temperature}");
					Console.WriteLine($"Capacity (L): {arr[i].Capacity}L");
				}
			}
			public void ShowInfo()
			{
				Console.WriteLine($"-------------- Freezer [{model}] --------------");
				Console.WriteLine($"Temperature: +{temperature}");
				Console.WriteLine($"Capacity (L): {capacity}L");
			}

			public void TestFreezer()
			{
				Console.WriteLine($"Freezer: {Model}, +{Temperature}");
			}
		
			public override string ToString()
			{
				return $"Freezer: {model} {capacity}L {manufactureYear}";
			}
			
		}
		*/
	}
}
