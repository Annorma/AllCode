using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05_FootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FootballTeam team = new FootballTeam("Super Team");

            Console.WriteLine(" -=-=-=-=-=-= Team -=-=-=-=-=-=-");
            foreach (var player in team)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("----------------------------------");

            team.Sort();

            Console.WriteLine(" -=-=-=-=-=-= Sorted Team by Koef -=-=-=-=-=-=-");
            foreach (var player in team)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("----------------------------------");

            team.Sort(new NameComparer());
            Console.WriteLine(" -=-=-=-=-=-= Sorted Team by Name -=-=-=-=-=-=-");
            foreach (var player in team)
            {
                Console.WriteLine(player);
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑

        /*
        struct Statistic
        {
            public int Goals { get; set; }
            public int Games { get; set; }
            public float AverageGoalsPerGame => (float)Goals / Games; // get { return Goals / Games; }

            public Statistic(int goals, int games)
            {
                Goals = goals;
                Games = games;
            }

            public override string ToString()
            {
                return $"Statistics: {Goals} / {Games} - Koef: {AverageGoalsPerGame}";
            }
        }

        class FootbalPlayer : IComparable<FootbalPlayer>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public Statistic Stats { get; set; }

            public int CompareTo(FootbalPlayer other)
            {
                return this.Stats.AverageGoalsPerGame.CompareTo(other.Stats.AverageGoalsPerGame);
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName} - {BirthDate.ToShortDateString()}\n" +
                       $"{Stats}";
            }
        }

        class FootballTeam : IEnumerable
        {
            public string Name { get; set; }
            private FootbalPlayer[] players;

            public FootballTeam()
            {
                Name = "Anonymous";
                players = new FootbalPlayer[]
                {
                new FootbalPlayer()
                {
                    FirstName = "Yevhen",
                    LastName = "Konoplyanka",
                    BirthDate = new DateTime(1989, 9, 29),
                    Stats = new Statistic(78, 120),
                },
                new FootbalPlayer()
                {
                    FirstName = "Oleksandr",
                    LastName = "Zinchenko",
                    BirthDate = new DateTime(1996, 12, 15),
                    Stats = new Statistic(70, 56),
                },
                new FootbalPlayer()
                {
                    FirstName = "Zlatan",
                    LastName = "Ibrahimović",
                    BirthDate = new DateTime(1981, 10, 3),
                    Stats = new Statistic(89, 144),
                },
                new FootbalPlayer()
                {
                    FirstName = "Neymar",
                    LastName = "JR",
                    BirthDate = new DateTime(1992, 2, 5),
                    Stats = new Statistic(130, 99),
                },
                new FootbalPlayer()
                {
                    FirstName = "Andriy",
                    LastName = "Shevchenko",
                    BirthDate = new DateTime(1976, 9, 29),
                    Stats = new Statistic(90, 210),
                }
                };
            }
            public FootballTeam(string name) : this()
            {
                Name = name;
            }

            public void Sort()
            {
                Array.Sort(players);
            }

            public void Sort(IComparer<FootbalPlayer> comparer)
            {
                Array.Sort(players, comparer);
            }

            public IEnumerator GetEnumerator()
            {
                return players.GetEnumerator();
            }
        }

        class NameComparer : IComparer<FootbalPlayer>
        {
            public int Compare(FootbalPlayer x, FootbalPlayer y)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
        }
        */


    }
}
