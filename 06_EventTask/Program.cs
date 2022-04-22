using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_Tasks
{
    class Program
    {

        
        static void Main(string[] args)
        {
            /*
            List<Trader> traders = new List<Trader>
            {
                new Trader
                {
                FirstName = "John",
                LastName = "Miller",
                },
                new Trader
                {
                FirstName = "Candice",
                LastName = "Leman",
                },
                new Trader
                {
                FirstName = "Joey",
                LastName = "Finch",
                },
                new Trader
                {
                FirstName = "Nicole",
                LastName = "Taylor",
                }
            };

            Exchange exchange = new Exchange();
            foreach (Trader item in traders)
            {
                exchange.MaxTradeEvent += item.Sell;
                exchange.MinTradeEvent += item.Buy;
            }

            exchange.Schedule();


            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑

        /*
        public delegate void TradeDelegate();
        class Trader
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void Buy()
            {
                WriteLine($"Trader {FirstName} {LastName} bought new goods...");
            }
            public void Sell()
            {
                WriteLine($"Trader {FirstName} {LastName} sold his goods...");
            }
        }
        class Exchange
        {
            Random rand = new Random();
            int course = 0;
            public int Course { get => course; }

            public event TradeDelegate MaxTradeEvent;
            public event TradeDelegate MinTradeEvent;
            public void MinTrade()
            {
                if (course <= 20)
                {
                    MinTradeEvent?.Invoke();
                }
            }
            public void MaxTrade()
            {
                if (course >= 80)
                {
                    MaxTradeEvent?.Invoke();
                }
            }
            public void Schedule()
            {
                for (int i = 0; i < 10; i++)
                {
                    course = rand.Next(1, 100);
                    MaxTrade();
                    MinTrade();
                }
            }
        }
        */


    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
