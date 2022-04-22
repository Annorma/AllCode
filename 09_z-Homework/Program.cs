using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using static System.Console;

namespace _09_z_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            do
            {
                int choice = 0;
                Clear();
                WriteLine("\tForum\t\n[1] - Register\n[2] - Show users\n[3] - Serialize");
                choice = int.Parse(ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Clear();
                            WriteLine("-------Registration------\n");
                            
                            Write("Enter login: ");
                            string log = ReadLine();

                            Write("Enter password [>8, A-Z, a-z, 0-9]: ");
                            string pass = ReadLine();

                            Write("Confirm password: ");
                            string cfrmpass = ReadLine();

                            Write("Enter email: ");
                            string mail = ReadLine();

                            Write("Enter credit card number [5375414105397540]: ");
                            string card = ReadLine();

                            Write("Enter phone number [+38(0XX)XXX-XXXX]: ");
                            string phone = ReadLine();

                            //Example: Artem, Password123, Password123, artem@gmail.com, 5375414105397540, +38(096)384-8469 - true;
                            user.Add(log, pass, cfrmpass, mail, card, phone);
                            break;
                        }
                    case 2:
                        {
                            Clear();
                            user.Show();
                            ReadKey();
                            break;
                        }
                    case 3:
                        {    
                            Clear();
                            user.Save();
                            ReadKey();
                            break;
                        }
                    default: { break; }
                }
            } while (true);

            WriteLine("\n\nEnd...");
            ReadKey();



        } //--------------------Main--------------------↑


        [Serializable]
        class User
        {
            private static Dictionary<int, string> accounts = new Dictionary<int, string>();
            private int Id = 999;
            private string login = "";
            private string password = "";
            private string confirmPass = "";
            private string email = "";
            private string creditCard = "";
            private string phone = "";
            string result = "";

            private string Login { get => login; set => login = value; }
            public string Result { get => result; set => result = value; }
            public string Password { get => password; set => password = value; }
            public string ConfirmPassword { get => confirmPass; set => confirmPass = value; }
            public string Email { get => email; set => email = value; }
            public string CreditCard { get => creditCard; set => creditCard = value; }
            public string Phone { get => phone; set => phone = value; }

            public User() { }

            private bool logCheck()
            {
                Match match = Regex.Match(Login, @"^([a-zA-Z-]{1,30})$");
                if (match.Success) { return true; }
                else { return false; }
            }
            private bool passCheck()
            {
                Match match = Regex.Match(Password, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{8,}$");
                if (match.Success) { return true; }
                else { return false; }
            }
            private bool pass2Check()
            {
                if (ConfirmPassword == Password) { return true; }
                else { return false; }
            }
            private bool emailCheck()
            {
                Match match = Regex.Match(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (match.Success) { return true; }
                else { return false; }
            }
            private bool cardCheck()
            {
                Match match = Regex.Match(CreditCard, @"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");
                if (match.Success) { return true; }
                else { return false; }
            }
            private bool phoneCheck()
            {
                Match match = Regex.Match(Phone, @"^\+(\d{2})(\()(\d{3})([\).\s])(\d{3})([-\.\s])(\d{4})(?!\d)$");
                if (match.Success) { return true; }
                else { return false; }
            }
            public void Add(string log, string pass, string cfrmpass, string mail, string card, string phone)
            {
                Id++; Login = log; Password = pass; ConfirmPassword = cfrmpass; Email = mail; CreditCard = card; Phone = phone;
                if (logCheck() == true && passCheck() == true && pass2Check() == true && emailCheck() == true && cardCheck() == true && phoneCheck() == true)
                {
                    Result = Login + " " + Password + " " + Email + " " + CreditCard + " " + Phone;
                    accounts.Add(Id, Result);
                }
                else { WriteLine("Invalid data!!!"); }
            }
            public void Show()
            {
                foreach (KeyValuePair<int, string> keyValue in accounts)
                {
                    WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
            }
            public void Save()
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                try
                {
                    // serialization
                    using (Stream fStream = File.Create("users.bin"))
                    {
                        binFormat.Serialize(fStream, accounts);
                    }
                    WriteLine("Serialize done!\n");

                    // deserialization
                    Dictionary<int, string> a = null;
                    using (Stream fStream = File.OpenRead("users.bin"))
                    {
                        a = (Dictionary<int, string>)binFormat.Deserialize(fStream);
                    }
                    foreach (KeyValuePair<int, string> keyValue in a)
                    {
                        WriteLine(keyValue.Key + " - " + keyValue.Value);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex);
                }
            }
        }













    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
