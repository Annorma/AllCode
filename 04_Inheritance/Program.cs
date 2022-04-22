using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Router1Channel router1 = new Router1Channel("TP-Link 3434", "Gray", "11ac");
            Phone phone = new Phone("iPhone 13 Pro", "Black");

            Device[] devices =
            {
                router1,
                phone,
                new Router2Channel("D-link", "Red", "11ax")
            };

            foreach (var d in devices)
            {
                Console.WriteLine(d.ToString());
                d.DoWork();
                Console.WriteLine(new string('-', 30));
            }

            Device device = router1;
            device.DoWork();

            Router1Channel router;
            // 1 - using type conversion
            try
            {
                router = (Router1Channel)device;
                router.ConnectToNetwork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot conver the types!");
            }

            // 2 - using operator 'as'
            router = device as Router1Channel;
            if (router == null)
                Console.WriteLine("Cannot conver the types!");

            router?.ConnectToNetwork();


            // 3 - using 'as' and 'is' operators
            if (device is Router1Channel)
            {
                router = device as Router1Channel;
                router.ConnectToNetwork();
            }
            else
                Console.WriteLine("Cannot conver the types!");


            Console.WriteLine("\n\nEnd...");
            Console.ReadKey();
        }




    } //--------------------Main--------------------↑

        // protected            - allow access from inherit classes
        // protected internal   - allow access from inherit classes only in assembly

        // internal - default
        abstract class Device : object // all your own classes already inherit the object class
        {
            private static int id = 100000;
            protected bool isPowerOn;   // can access from derived classes

            public string Model { get; set; }
            public string Color { get; set; }
            public int SerialNumber { get; set; }

            public DateTime ManufactureDate { get; set; }

            public Device() : this("No model", "No color")
            { }
            public Device(string m, string c)
            {
                Model = m;
                Color = c;
                SerialNumber = id++;
                ManufactureDate = DateTime.Now;
            }

            public void PowerSwitch()
            {
                isPowerOn = !isPowerOn;
            }

            // abstract - method without realization
            public abstract void DoWork();

            public override string ToString()
            {
                return $"Device: {Model} {Color}\n" +
                    $"Status: {(isPowerOn ? "ON" : "OFF")}\n";
            }
        }

        class Router1Channel : Device // : base_class, interface1, interface2...
        {
            public string WifiVersion { get; set; }
            public Router1Channel(string m, string c, string wv) : base(m, c)
            {
                WifiVersion = wv;
            }
            public override void DoWork()
            {
                Console.WriteLine("Connect to WAN. Share internet data with clients!");
            }

            // polymorphism with the words {virtual} and {override}
            public virtual void ConnectToNetwork()
            {
                Console.WriteLine("Connecting using 2.4GHz channel!");
            }

            public override string ToString()
            {
                return base.ToString() +
                    $"Wi-Fi Version: {WifiVersion}\n";
            }
        }

        class Router2Channel : Router1Channel
        {
            public Router2Channel(string m, string c, string wv) : base(m, c, wv)
            { }

            public sealed override void ConnectToNetwork()
            {
                Console.WriteLine("Connecting using 2.4GHz and 5GHz channels!");
            }
        }


        // sealed - can`t has a child class
        sealed class FinalRouter : Router2Channel
        {
            public FinalRouter(string m, string c, string wv) : base(m, c, wv) { }

            // cannot ovverride sealed method
            //public override void ConnectToNetwork()
            //{
            //    base.ConnectToNetwork();
            //}
        }

        class Phone : Device
        {
            public Phone(string m, string c) : base(m, c)
            { }

            public override void DoWork()
            {
                Console.WriteLine("Make a call! Take a photo!");
            }
        }
}
