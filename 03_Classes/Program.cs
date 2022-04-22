using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car = new Car("Ferrari F12", "Red", 2018, 60);

            Console.WriteLine(car?.ToString());

            //car.SetSpeed(-90);
            //Console.WriteLine("Current speed: " + car.GetSpeed() + "km/h");

            car.Speed = 60;                 // property set
            Console.WriteLine(car.Speed);   // property get

            car.Color = "   ";
            Console.WriteLine("Color: " + car.Color);

            //car.ManufactureYear = 0; // readonly property
            Console.WriteLine("Car age: " + car.Age);

            Console.WriteLine(car);
            
            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
             */

        } //--------------------Main--------------------↑


        // Access Specificators
        /*
         * private (default for fields)
         * protected internal
         * protected 
         * internal - access from assembly only (default for classes)
         * public
         */
        /*
        internal class Car : object // all your own classes already inherite the object
        {
            // not in C#
            //private:
            //public:
            // ------------ Fields ------------
            string model; // private by default
            private string color;

            private readonly int manufactureYear;   // can initialize or set in constructors
            private const int id = 1234;            // can initialize only

            private static int count;

            // ------------ Properties ------------
            // full property (snippet: propfull)
            private float speed;
            public float Speed
            {
                get
                {
                    return speed;
                }
                set
                {
                    speed = (value >= 0 ? value : 0);
                }
            }

            // auto-property (snippet: prop)
            public string Type { get; set; }

            public string Color
            {
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        color = value;
                }
                get
                {
                    return color;
                }
            }

            // readonly property (only get)
            //public int ManufactureYear
            //{
            //    //get
            //    //{
            //    //    return manufactureYear;
            //    //}
            //    get => manufactureYear;
            //}
            public int ManufactureYear => manufactureYear;

            public int Age => DateTime.Now.Year - ManufactureYear;

            // static property
            public static int Count => count;

            // ------------ Constructors ------------
            // * can be only one
            // * auto invoke
            static Car()
            {
                // initialize static members
                count = 1000;
            }
            public Car()
            {
                // auto initialize with default values: false, 0, null
            }
            public Car(string model, string color, int year)
            {
                this.model = model;
                this.color = color;
                manufactureYear = year;
            }
            public Car(string model, string color, int year, float speed) : this(model, color, year)
            {
                //this.model = model;
                //this.color = color;
                //manufactureYear = year;

                //if (speed >= 0)
                //    this.speed = speed;
                //else
                //    this.speed = 0;
                //SetSpeed(speed);
                Speed = speed;
            }

            // ------------ Methods ------------
            // getters and setters
            //public void SetSpeed(float speed)
            //{
            //    if (speed >= 0)
            //        this.speed = speed;
            //    else
            //        this.speed = 0;
            //}
            //public float GetSpeed()
            //{
            //    return speed;
            //}

            public void Drive()
            {
                Console.WriteLine($"Driving with speed {Speed}km/h");
            }

            public override string ToString()
            {
                return $"Car {model} {color} {manufactureYear}";
            }
        }
        */
    }
}
