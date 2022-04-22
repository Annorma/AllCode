using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1

            /*
            Frog frog = new Frog("Frog Alice", 5, "red");
            Karp karp = new Karp("Karp John", 12, 250);
            Eagle eagle = new Eagle("Eagle Fred", 90, 180);

            Animal[] zoo = { frog, karp, eagle };

            foreach (var a in zoo)
            {
                WriteLine(a.ToString());
                a.Move(2);
                a.MakeSound();
                WriteLine(new string('-', 30));
            }


            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 2

            /*
            Rectangle r1 = new Rectangle(5, 12);
            WriteLine(r1);

            Square s1 = new Square(3, 6);
            WriteLine(s1);

            SealedShape sealedshape = new SealedShape(new Rectangle(6,15), new Square(12, 15));
            WriteLine(sealedshape);

            

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑

        //Task 1

        /*
        abstract class Animal
        {
            private string name;
            float maxSpeed;

            public Animal() : this("No name", 0) { }
            public Animal(string n, float ms)
            {
                name = n;
                maxSpeed = ms;
            }

            public string Name { get => name; }
            public float MaxSpeed { get => maxSpeed; }

            public abstract void Move(float speed);
            public abstract void MakeSound();

            public override string ToString()
            {
                return $"Animal: {name}\nMax speed: {maxSpeed} km/h\n";
            }

        }

        class Reptile : Animal
        {
            private string color;
            public Reptile(string n, float ms, string c) : base(n, ms)
            {
                color = c;
            }
            public string Color { get => color; }

            public override void MakeSound()
            {
                WriteLine("Reptile sounds...");
            }

            public override void Move(float speed)
            {
                WriteLine($"Moving with speed: {speed}/{MaxSpeed} km/h");
            }
        }

        class Bird : Animal
        {
            private float flightAltitude;
            public Bird(string n, float ms, float fa) : base(n, ms)
            {
                flightAltitude = fa;
            }
            public float FlightAltitude { get => flightAltitude; }

            public override void MakeSound()
            {
                WriteLine("Bird sounds...");
            }

            public override void Move(float speed)
            {
                WriteLine($"Flying with speed: {speed}/{MaxSpeed} km/h\nMax flight altitude: {FlightAltitude}m");
            }
        }

        class Fish : Animal
        {
            private float swimmingDepth;
            public Fish(string n, float ms, float sw) : base(n, ms)
            {
                swimmingDepth = sw;
            }
            public float SwimmingDepth { get => swimmingDepth; }

            public override void MakeSound()
            {
                WriteLine("Fish sounds...");
            }

            public override void Move(float speed)
            {
                WriteLine($"Swimming with speed: {speed}/{MaxSpeed} km/h\nMax swimming depth: {SwimmingDepth}m");
            }
        }

        class Frog : Reptile
        {
            public Frog(string n, float ms, string c) : base(n, ms, c) { }

            public override void MakeSound()
            {
                WriteLine("Frog sounds...");
            }

            public override void Move(float speed)
            {
                WriteLine($"Moving with speed: {speed}/{MaxSpeed} km/h");
            }
        }

        sealed class Eagle : Bird
        {
            public Eagle(string n, float ms, float fa) : base(n, ms, fa) { }

            public sealed override void MakeSound()
            {
                WriteLine("Eagles sounds...");
            }

            public sealed override void Move(float speed)
            {
                WriteLine($"Flying with speed: {speed}/{MaxSpeed} km/h\nMax flight altitude: {FlightAltitude}m");
            }
        }

        sealed class Karp : Fish
        {
            public Karp(string n, float ms, float sw) : base(n, ms, sw) { }

            public sealed override void MakeSound()
            {
                WriteLine("Karp sounds...");
            }

            public sealed override void Move(float speed)
            {
                WriteLine($"Swimming with speed: {speed}/{MaxSpeed} km/h\nMax swimming depth: {SwimmingDepth}m");
            }
        }
        */


        //Task 2

        /*
        abstract class Shape
        {
            public abstract double GetArea();
        };

        class Rectangle : Shape
        {
            public int A { get; set; }
            public int B { get; set; }
            public Rectangle() : this(0, 0) { }
            public Rectangle(int a, int b)
            {
                A = a;
                B = b;
            }
            public override double GetArea()
            {
                return A * B;
            }

            public override string ToString()
            {
                return $"\nName: Rectangle\nA: {A}cm\nB: {B}cm\nArea: {GetArea()}cm^2";
            }
        };


        class Square : Shape
        {

            public int A { get; set; }
            public int B { get; set; }
            public Square() : this(0, 0) { }
            public Square(int a, int b)
            {
                A = a;
                B = b;
            }
            public override double GetArea()
            {
                return A * B;
            }

            public override string ToString()
            {
                return $"\nName: Square\nA: {A}cm\nB: {B}cm\nArea: {GetArea()}cm^2";
	        }

        };
        
        class SealedShape : Shape
        {
            Shape[] shapes;
            
            public SealedShape(params Shape[] arr)
            {
                shapes = arr;
            }
            public override double GetArea()
            {
                double rez = 0;
                foreach (var item in shapes)
                {
                    rez += item.GetArea();
                }
                return rez;
            }



            public override string ToString()
            {
                string str = "";
                foreach (var item in shapes)
                {
                    str += new string('_', 15);
                    str += item + "\n";
                }
                str += $"\nSealedShape's area: {GetArea()}cm^2\n";
                return str;
            }
        }
        */

    }
}
