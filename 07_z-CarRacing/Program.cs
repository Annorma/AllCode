using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace _07_z_CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();                                                                            //Ініціалізація класу "Автомобіль"
            Bus bus = new Bus();                                                                            //Ініціалізація класу "Автобус"
            Sport_Car sportcar = new Sport_Car();                                                           //Ініціалізація класу "Спортивний автомобіль"
            Cargo_Car cargocar = new Cargo_Car();                                                           //Ініціалізація класу "Вантажний автомобіль"

            List<Thread> vehicles = new List<Thread>()                                                      //Створення списку транспорту з методами що почнуть виконуватися при виклиці
            {
                new Thread(car.Ride),
                new Thread(bus.Ride),
                new Thread(sportcar.Ride),
                new Thread(cargocar.Ride)
            };
            foreach (Thread v in vehicles)                                                                  //Цикл що проходиться по списку транспорту запускаючи виконання методів
            {
                v.Start();                                                                                  
            }

            WriteLine("--------Finish--------\n");                                                          //Виведення в консоль лінії фінішу
            ReadKey();                                                                                      //Пауза




        } //--------------------Main--------------------↑

        abstract class Vehicle                                                                              //Створення абстрактного класу "Транспортний засіб"
        {
            public delegate void Start();                                                                   //Створення делегації "Початок"
            public delegate void Message();                                                                 //Створення делегації "Повідомлення"
            public event Message Show;                                                                      //Створення події "Показати" на основі делегації "Повідомлення"
            public int GetSpeed(Random rand, int r1, int r2)                                                //Створення властивості "Отримати швидкість", яка повертатиме випадкову швидкість
            {
                int speed;
                return speed = rand.Next(r1, r2 + 1);
            }

            public void Win(string name)                                                                    //Створення властивості "Перемога", яка виведе повідомлення що авто фінішувало
            {
                WriteLine($"{name} arrived");
            }

            public void Go(string name, int speed)                                                          //Створення властивості "Йти", яка починає гонку та перевіряє чи авто фінішувало
            {
                int distance = 0;
                Show += () => Win(name);                                                                    //Присвоєння властивості "Перемога" для події "Показати"
                for (int i = 0; i < 110; i += 10, distance += 10)
                {
                    Thread.Sleep((speed * -1) + 250);                                                       //Функція яка переводить швидкість у час затримки виведення у консолі
                    if (distance == 100)                                                                    //(Авто із більшою швидкістю виводяться першими, ніби вони фінішували скоріше)
                    {
                        Write($"({speed} km/h) ");
                        Show();
                    }
                }
            }
        }
        class Car : Vehicle                                                                                 //Створення класу "Авто" який наслідує клас "Транспортний засіб"
        {
            public string Name = "Car";                                                                     //Створення змінної "Ім'я" яка надає ім'я транспорту
            public void Ride()                                                                              //Створення властивості "Їхати" яка викликає функцію початку руху
            {
                Go(Name, GetSpeed(new Random(), 40, 180));
            }
        }

        class Sport_Car : Vehicle                                                                           //Створення класу "Спортивне авто" який наслідує клас "Транспортний засіб"
        {
            public string Name = "Sport car";                                                               //Створення змінної "Ім'я" яка надає ім'я транспорту
            public void Ride()                                                                              //Створення властивості "Їхати" яка викликає функцію початку руху
            {
                Go(Name, GetSpeed(new Random(), 41, 250));
            }
        }

        class Cargo_Car : Vehicle                                                                           //Створення класу "Вантажне авто" який наслідує клас "Транспортний засіб"
        {
            public string Name = "Cargo car";                                                               //Створення змінної "Ім'я" яка надає ім'я транспорту
            public void Ride()                                                                              //Створення властивості "Їхати" яка викликає функцію початку руху
            {
                Go(Name, GetSpeed(new Random(), 39, 140));
            }
        }

        class Bus : Vehicle                                                                                 //Створення класу "Автобус" який наслідує клас "Транспортний засіб"
        {
            public string Name = "Bus";                                                                     //Створення змінної "Ім'я" яка надає ім'я транспорту
            public void Ride()                                                                              //Створення властивості "Їхати" яка викликає функцію початку руху
            {
                Go(Name, GetSpeed(new Random(), 38, 120));
            }
        }
    





    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
