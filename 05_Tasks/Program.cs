using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cinema cinema = new Cinema();

            WriteLine(" -=-=-=-=-=-= Movies -=-=-=-=-=-=-\n");
            foreach (var movie in cinema)
            {
                WriteLine(movie);
            }
            WriteLine("----------------------------------");

            cinema.Sort();

            WriteLine("\n -=-=-=-=-=-= Sorted Movie by Rating -=-=-=-=-=-=-\n");
            foreach (var movie in cinema)
            {
                WriteLine(movie);
            }
            WriteLine("----------------------------------");

            cinema.Sort(new YearComparer());

            WriteLine("\n -=-=-=-=-=-= Sorted Movie by Year -=-=-=-=-=-=-\n");
            foreach (var movie in cinema)
            {
                WriteLine(movie);
            }
            WriteLine("----------------------------------");

            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 2


            /*
            int index = 0;
            do
            {
                Worker worker = new Worker();

                try
                {
                    Write("Name: ");
                    string name = ReadLine();
                    worker.Name = name;
                }
                catch (ArgumentNullException e)
                {
                    WriteLine(e.Message);
                    break;
                }
                try
                {
                    Write("Surname: ");
                    string surname = ReadLine();
                    worker.Surname = surname;
                }
                catch (ArgumentNullException e)
                {
                    WriteLine(e.Message);
                    break;
                }
                try
                {
                    Write("Age: ");
                    int age = int.Parse(ReadLine());
                    worker.Age = age;
                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                    break;
                }
                try
                {
                    Write("Salary: $");
                    int salary = int.Parse(ReadLine());
                    worker.Salary = salary;
                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                    break;
                }

                WriteLine(worker);
                index++;
            } while (index < 1);

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑

        /*
        class Movie : IComparable<Movie>
        {
            private string name;
            private string description;
            private string country;
            private int year;
            private double rating;

            public Movie() : this("No name", "no description", "no country", 0, 0) { }
            public Movie(string n, string d, string ctry, int y, double r)
            {
                name = n;
                description = d;
                country = ctry;
                year = y;
                rating = r;
            }

            public string Name { get; set; }
            public string Description { get; set; }
            public string Country { get; set; }
            public int Year { get; set; }
            public double Rating { get; set; }

            public int CompareTo(Movie other)
            {
                return this.Rating.CompareTo(other.Rating);
            }

            public override string ToString()
            {
                return $"Film: {Name} {Year}\nRating: {Rating}\nDescription: {Description}\nCountry: {Country}\n\n";
            }

        }

        class YearComparer : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }

        class Cinema : IEnumerable
        {
            private Movie[] movies;

            public Cinema()
            {
                movies = new Movie[]
                    {
                        new Movie()
                        {
                            Name = "Venom 2",
                            Description = "New film from Marvel",
                            Country = "USA",
                            Year = 2021,
                            Rating = 8.8
                        },
                        new Movie()
                        {
                            Name = "Spider Man: No Way To Home",
                            Description = "The third film about Spider Man",
                            Country = "USA",
                            Year = 2022,
                            Rating = 9.2
                        },
                        new Movie()
                        {
                            Name = "Sonic",
                            Description = "Film about the most famous SEGA character",
                            Country = "England",
                            Year = 2020,
                            Rating = 7.9
                        },
                        new Movie()
                        {
                            Name = "Guardians Of The Galaxy",
                            Description = "Someone must protect the galaxy",
                            Country = "France",
                            Year = 2017,
                            Rating = 7.2
                        },
                        new Movie()
                        {
                            Name = "Cars 3",
                            Description = "Kchayyyy",
                            Country = "Spain",
                            Year = 2019,
                            Rating = 6.3
                        },



                    };
            }

            public void Sort()
            {
                Array.Sort(movies);
            }

            public void Sort(IComparer<Movie> comparer)
            {
                Array.Sort(movies, comparer);
            }

            public IEnumerator GetEnumerator()
            {
                return movies.GetEnumerator();
            }
        }
        */



        //Task 2

        /*
        class Worker
        {
            private string name;
            private string surname;
            private int age;
            private int salary;

            public Worker() { }
            public Worker(string name, string surname, int age, int salary)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Salary = salary;
            }

            public string Name
            {
                get => name;
                set
                {
                    if (value == null || value == " ")
                    {
                        throw new ArgumentNullException("Please enter correct name!");
                    }
                    name = value;
                }
            }
            public string Surname
            { 
                get => surname;
                set
                {
                    if (value == null || value == " ")
                    {
                        throw new ArgumentNullException("Please enter correct surname!");
                    }
                    surname = value;
                }
            }
            public int Age
            { 
                get => age;
                set
                {
                    if (value <= 0 || value >= 100)
                    {
                        throw new FormatException("Please enter correct age!");
                    }
                    age = value;
                }
            }
            public int Salary
            {
                get => salary;
                set
                {
                    if (value <= 0)
                    {
                        throw new FormatException("Please enter correct salary!");
                    }
                    salary = value;
                }

            }
            public override string ToString()
            {
                return $"{Name} {Surname} {Age} y.o - ${Salary}";
            }
        }
        */

    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
