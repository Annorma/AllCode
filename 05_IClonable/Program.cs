using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var player = new FootbalPlayer()
            {
                FirstName = "Yevhen",
                LastName = "Konoplyanka",
                BirthDate = new DateTime(1989, 9, 29),
                Stats = new Statistic(78, 120),
            };

            FootbalPlayer other = (FootbalPlayer)player.Clone();
            other.BirthDate = DateTime.Now;
            other.Stats.Goals = 0;

            Console.WriteLine(player);

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑


        /*
        class Statistic : ICloneable
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

            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }

        class FootbalPlayer : IComparable<FootbalPlayer>, ICloneable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public Statistic Stats { get; set; }

            // deep copy - copy all properties and references
            public object Clone()
            {
                // MemberwiseClone - shallow copy (copy only value types)
                var copy = (FootbalPlayer)this.MemberwiseClone();
                copy.FirstName = (string)this.FirstName.Clone();
                copy.LastName = (string)this.LastName.Clone();
                copy.Stats = (Statistic)this.Stats.Clone();
                //copy.Stats = new Statistic(this.Stats.Goals, this.Stats.Games);

                return copy;
            }

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
        */




    }
}
