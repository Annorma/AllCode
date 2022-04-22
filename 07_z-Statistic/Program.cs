using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _07_z_Statistic
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiters = { ' ', ',', '.' };                                                      //Створення масиву символів | ↓Текст для перевірки роботи програми↓
            string s = "Here is the house that Jack built. And this is wheat, which is stored in a dark closet in the house that Jack built. And this is a funny birdtit, which often steals wheat, which is kept in a dark closet in the house, that Jack built.";
            string[] text = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);                 //Створення масиву слів прибираючи символи та пробіли
            var cw = new CountWords();                                                                  //Ініціалізація класу "Кількість слів"
            foreach (string i in text)                                                                  //Цикл додавання слів в колекцію Dictionary
            {
                cw.Add(i);
            }
            WriteLine("Word:\t\t\t\tAmount:\n");
            cw.PrintStatistic();                                                                        //Виведення фінальної статистики

            WriteLine("\n\nEnd...");
            ReadKey();


        } //--------------------Main--------------------↑



        class CountWords                                                                                //Створення класу "Кількість слів"
        {
            private static Dictionary<string, int> stats;                                               //Створення колекції

            public CountWords()                                                                         //Конструктор класу
            {
                stats = new Dictionary<string, int>();
            }

            public void Add(string word)                                                                //Метод "Додавання" який додає слово або його частоту зустрічі в тексті
            {
                if (stats.ContainsKey(word))                                                            //Перевірка, якщо слово вже додане - збільшує кількість його зустрічі в тексті...
                {
                    stats[word] += 1;
                }
                else                                                                                    //...якщо ні - додає слово
                {
                    stats.Add(word, 1);
                }
            }

            public void PrintStatistic()                                                                //Метод "Виведення статистики" який виводить статистику
            {
                foreach (var i in stats)
                {
                    WriteLine($"{i.Key}\t--\t--\t--\t{i.Value}");
                }
            }
        }





    } //--------------------Program--------------------↑
} //--------------------Namespace-------------------↑
