using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.Bank privatBank = new Bank.Bank();
            privatBank.OpenAnAccount("Artem", "Delidon", 19, 100, 2112);
            ReadKey();

            int attempt = 0;
            do
            {
                Clear();
                WriteLine("_____Welcome to PRIVAT 24_____");
                WriteLine("Enter your data to use the ATM");
                Write($"Account ID: ");
                int id = int.Parse(ReadLine());
                Write("Password: ");
                int pass = int.Parse(ReadLine());

                if (id == privatBank.AccountID && pass == privatBank.Password)
                {
                    Clear();
                    WriteLine($"_____Welcome back {privatBank.Name}_____");
                    ReadKey();
                    do
                    {
                        Clear();
                        WriteLine("_____PRIVAT 24_____\n1 - Show balance\n2 - Refill balance\n3 - Withdraw money\n4 - Exit");
                        int i = int.Parse(ReadLine());
                        switch (i)
                        {
                            case 1:
                                {
                                    Clear();
                                    WriteLine($"_____PRIVAT 24_____\nYour balance: ${privatBank.Money}");
                                    ReadKey();
                                    break;
                                }
                            case 2:
                                {
                                    Clear();
                                    Write($"_____PRIVAT 24_____\nEnter sum: $");
                                    int sum = int.Parse(ReadLine());
                                    privatBank.Money += sum;
                                    WriteLine($"Your balance was refilled with ${sum}");
                                    ReadKey();
                                    break;
                                }
                            case 3:
                                {
                                    Clear();
                                    Write($"_____PRIVAT 24_____\nEnter sum: $");
                                    int sum = int.Parse(ReadLine());
                                    if (privatBank.Money >= sum)
                                    {
                                        privatBank.Money -= sum;
                                        WriteLine($"You withdraw ${sum}");
                                    }
                                    else
                                    {
                                        WriteLine("Not enough money!");
                                    }
                                    ReadKey();
                                    break;
                                }
                            case 4:
                                {
                                    Clear();
                                    WriteLine("_____PRIVAT 24_____\nGoodbye ;)\nDon't forget your card!");
                                    ReadKey();
                                    return;
                                }

                            default:
                                {
                                    Clear();
                                    WriteLine("_____PRIVAT 24_____\nChoose correct action!");
                                    ReadKey();
                                    break;
                                }
                        }
                    } while (true);
                }
                else
                {
                    attempt++;
                }
                if (attempt == 3) { Clear(); WriteLine("_____PRIVAT 24_____\nTry log in later!"); ReadKey(); return; }
            } while (true);

            

        } //--------------------Main--------------------↑


        //_04_z_Lab_3


    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑


namespace Bank
{
    class Bank
    {
        private int accountId = 0;
        Random rand = new Random();
        BankAccount.Account ac = new BankAccount.Account();
        public Bank() { }
        public void OpenAnAccount(string name, string surname, int age, double startSum, int pass)
        {
            if (age < 18) { WriteLine("You must 18 years old or older!"); }
            if (pass < 1000 || pass > 9999) { WriteLine("Password can NOT start from zero or be longer than 4 symbols!"); }
            if (startSum < 100) { WriteLine("You need to deposit at least $100 to open a bank account"); }
            if (age >= 18 && pass >= 1000 && pass <= 9999 && startSum >= 100)
            {
                accountId = rand.Next(100000, 999999);
                ac.OpenAnAccount(accountId, name, surname, age, startSum, pass);
            }
        }
        public string Name { get => ac.Name; }
        public int AccountID { get => ac.AccountId; }
        public int Password { get => ac.Password; }
        public double Money { get => ac.SumOfMoney; set => ac.SumOfMoney = value; }

    }
} //--------------------Bank--------------------↑

namespace BankAccount
{
    class Account
    {
        private string name;
        private string surname;
        private int age;
        private int password;
        private int accountId;
        private double sumOfMoney;
        public Account() { }

        public int Password { get => password; }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public int Age { get => age; }
        public int AccountId { get => accountId; }
        public double SumOfMoney { get => sumOfMoney; set => sumOfMoney = value; }
        public void OpenAnAccount(int accountId, string name, string surname, int age, double startSum, int pass)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            password = pass;
            this.accountId = accountId;
            sumOfMoney = startSum;
            WriteLine($"Bank account successfully created");
            WriteLine($"Your ID: {AccountId}");
            WriteLine($"Your password: {Password}");
            WriteLine($"(remember your ID and password!)");
        }
        public override string ToString()
        {
            return $"\nAccount Data\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nAccount ID: {AccountId}\nMoney: ${SumOfMoney}";
        }
    }

} //--------------------BankAccount--------------------↑
