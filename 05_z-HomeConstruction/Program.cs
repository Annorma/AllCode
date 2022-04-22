using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _05_z_HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            House house = new House();                                                          //Ініціалізація класу "Будинок"
            Team team = new Team();                                                             //Ініціалізація класу "Команда робочих"
            WriteLine(team.Name);                                                               //Виведення назви компанії

            team.tleader.Report();                                                              //Виведення звіту TeamLeader'а

            for (int i = 0; i < 3; i++)
            {
                team.worker[rand.Next(0, 4)].Build(house, team.tleader);                        //Цикл якиий рандомно вибирає Worker'а що буде створювати частину будинку
            }
            foreach (var reports in team.tleader.report)
            {
                WriteLine(reports);                                                             //Цикл виведення звіту який Worker що побудував
            }

            team.tleader.Report();                                                              //Виведення звіту TeamLeader'а
            WriteLine();

            for (int i = 0; i < 5; i++)
            {
                team.worker[rand.Next(0, 4)].Build(house, team.tleader);                        //Цикл якиий рандомно вибирає Worker'а що буде створювати частину будинку
            }
            foreach (var reports in team.tleader.report)
            {
                WriteLine(reports);                                                             //Цикл виведення звіту який Worker що побудував
            }
            team.tleader.Report();                                                              //Виведення звіту TeamLeader'а
            house.Show(team.tleader);                                                           //Виведення будинку
            WriteLine();

            for (int i = 0; i < 4; i++)
            {
                team.worker[rand.Next(0, 4)].Build(house, team.tleader);                        //Цикл якиий рандомно вибирає Worker'а що буде створювати частину будинку
            }
            foreach (var reports in team.tleader.report)
            {
                WriteLine(reports);                                                             //Цикл виведення звіту який Worker що побудував
            }
            team.tleader.Report();                                                              //Виведення звіту TeamLeader'а
            house.Show(team.tleader);                                                           //Виведення будинку


            WriteLine("\n\nEnd...");                                                            //Показ що програма завершилася
            ReadKey();

        } //--------------------Main--------------------↑



        interface IWorker                                                                       //Створення інтерфейсу IWorker
        {
            string Name { get; }                                                                //Getter імені робочих
        }
        interface IPart                                                                         //Створення інтерфейсу IPart
        {
            void Work(House house);                                                             //Властивість "Робота" яка буде виконувати будівництво будинку
        }

        class Roof : IPart                                                                      //Створення класу "Дах"
        {
            public void Work(House house)
            {
                house.roof = new Roof();                                                        //Властивість "Робота" яка буде виконувати будівництво даху
            }
        }

        class Window : IPart                                                                    //Створення класу "Вікно"
        {
            public void Work(House house)
            {
                house.windows.Add(new Window());                                                //Властивість "Робота" яка буде виконувати будівництво вікон
            }
        }

        class Door : IPart                                                                      //Створення класу "Двері"
        {
            public void Work(House house)
            {
                house.door = new Door();                                                        //Властивість "Робота" яка буде виконувати будівництво дверей
            }
        }

        class Walls : IPart                                                                     //Створення класу "Стіни"
        {
            public void Work(House house)
            {
                house.walls.Add(new Walls());                                                   //Властивість "Робота" яка буде виконувати будівництво стін
            }
        }

        class Basement : IPart                                                                  //Створення класу "Фундамент"
        {
            public void Work(House house)
            {
                house.basement = new Basement();                                                //Властивість "Робота" яка буде виконувати будівництво фундаменту
            }
        }

        class House                                                                             //Створення класу "Будинок"
        {
            public List<Walls> walls;                                                           //Створення масиву стін
            public List<Window> windows;                                                        //Створення масиву вікон
            public Basement basement;                                                           //Створення фундаменту
            public Roof roof;                                                                   //Створення даху
            public Door door;                                                                   //Створення дверей

            public void Show(TeamLeader tleader)                                                //Властивість "Показ" яка буде виводити будинок на екран
            {
                if (tleader.report.Count == 11)                                                 //Перевірка чи всі елементи будинку збудованні
                {
                                                                                                //Створення string'і з малюнком будинку (В консолі будинок виводиться як повинен)
                    string house = @"Enjoy your new house!                                      






                                                 /\
                                                /  \  /\
                    ___________________      /\/    \/  \    
           /\      /\        ______    \    /   /\/\  /\/\   
          /  \    //_\       \    /\    \  /\/\/    \/    \  
   /\    / /\/\  //___\       \__/__\    \/		   \         _     _
  /  \  /\/    \//_[]__\       \ |[]|     \		    \     _ / \   / \
 /\/\/\/       //_______\       \|__|      \		     \   / \ __\ /___\
/      \      /XXXXXXXXXX\                  \		      \ /___\  \ /   \
        \    /_I_II  I__I_\__________________\	               \/   \___/_____\
         \     I_II  I__I_____[]_|_[]_____I	               /_____\  /     \ 
          \    I_II  I__I_____[]_|_[]_____I		       /     \ /_______\
_______________I_II__I__I_____XXXXXXX_____I___________________/_______\ _\| |
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~                   | | | |  
              '   '                                              | |
          '   '";

                    WriteLine(house);                                                           //Виведення string'і з малюнком будинку на екран
                }
                else WriteLine("The house is not built yet!");                                  //Виведення повідомлення якщо будинок ще не збудований
            }
        }

        class Team : IWorker                                                                    //Створення класу "Команда"
        {
            public TeamLeader tleader;                                                          //Створення Teamleader'а
            public List<Worker> worker;                                                         //Створення масиву Worker'ів
            public string Name { get => "_________HouseBuild Inc. _________\n"; }               //Getter назви будівельної фірми

            public Team()                                                                       //Конструктор класу у якому можна створити імена робочим
            {
                tleader = new TeamLeader("Freddy");
                worker = new List<Worker> { new Worker("Bruce"), new Worker("Alan"), new Worker("Alex"), new Worker("John") };
            }
        }

        class Worker : IWorker                                                                  //Створення класу "Робітник"
        {
            string Name { get; set; }                                                           //Getter&setter імен робочих
            string IWorker.Name => Name;                                                        
            public Worker(string name)                                                          //Конструктор класу який присвоює імена робочим
            { Name = name; }

            public void Build(House house, TeamLeader tleader)                                  //Властивість "Будувати" яка будує та перевіряє які елементи будинку збудовані
            {
                if (house.basement == null)                                                     //Перевірка чи фундамент збудований
                {
                    Basement basement = new Basement();
                    basement.Work(house);
                    tleader.report.Add($"Worker {Name} builded a basement.");                   //Додавання до фінального звіту TeamLeader'а що робочий побудував фундамент
                }
                else if (house.walls == null || house.walls.Count < 4)                          //Перевірка чи стіни збудовані або яка кількість збудована
                {
                    if (house.walls == null) house.walls = new List<Walls>();
                    Walls wall = new Walls();
                    wall.Work(house);
                    tleader.report.Add($"Worker {Name} builded {house.walls.Count} wall.");     //Додавання до фінального звіту TeamLeader'а що робочий побудував стіну
                }
                else if (house.door == null)                                                    //Перевірка чи двері збудовані
                {
                    Door door = new Door();
                    door.Work(house);
                    tleader.report.Add($"Worker {Name} builded a door.");                       //Додавання до фінального звіту TeamLeader'а що робочий побудував двері
                }
                else if (house.windows == null || house.windows.Count < 4)                      //Перевірка чи вікна збудовані або яка кількість збудована
                {
                    if (house.windows == null) house.windows = new List<Window>();
                    Window window = new Window();
                    window.Work(house);
                    tleader.report.Add($"Worker {Name} builded {house.windows.Count} window."); //Додавання до фінального звіту TeamLeader'а що робочий побудував вікно
                }
                else if (house.roof == null)                                                    //Перевірка чи дах збудований
                {
                    Roof roof = new Roof();
                    roof.Work(house);
                    tleader.report.Add($"Worker {Name} builded a roof.");                       //Додавання до фінального звіту TeamLeader'а що робочий побудував дах
                }
            }
        }

        class TeamLeader : IWorker                                                              //Створення класу "Бригадир"
        {
            string Name { get; set; }                                                           //Getter&setter імен робочих
            public List<string> report = new List<string>();                                    //Створення масиву звітів
            string IWorker.Name => Name;
            public TeamLeader(string name) { Name = name; }                                     //Конструктор що присвоює ім'я бригадиру
            public void Report()                                                                //Властивість "Звіт" яка перевіряє який відсоток роботи виконаний
            {
                double workPercent = (report.Count / 11.0) * 100;                               //Змінна "Відсоток роботи" яка вираховує який відсоток роботи виконаний
                if ((int)workPercent == 0)                                                      //↓Перевірки яка частина роботи зроблена↓
                {
                    WriteLine($"TeamLeader {Name}: \"Work has NOT yet begun!\"");
                }
                if ((int)workPercent > 0 && (int)workPercent < 25)
                {
                    WriteLine($"TeamLeader {Name}: \"The work has just begun!\"");
                }
                if ((int)workPercent >= 25 && (int)workPercent < 50)
                {
                    WriteLine($"TeamLeader {Name}: \"A small part of work is done!\"");
                }
                else if ((int)workPercent == 50)
                {
                    WriteLine($"TeamLeader {Name}: \"Half of work is completed!\"");
                }
                else if ((int)workPercent > 50 && (int)workPercent < 75)
                {
                    WriteLine($"TeamLeader {Name}: \"Most of the work is completed!\"");
                }
                else if ((int)workPercent >= 75 && (int)workPercent < 100)
                {
                    WriteLine($"TeamLeader {Name}: \"Work is almost complete!\"");
                }
                else if((int)workPercent == 100)
                {
                    WriteLine($"TeamLeader {Name}: \"100 % of work completed!\"");
                }
            }
        }



    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
