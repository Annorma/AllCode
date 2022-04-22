using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using static System.Console;

namespace _08_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            /*
            string writePath = @"text.txt";
            string[] text = { "Somebody", "once", "told", "me", "The", "world", "is", "gonna", "roll", "me" };
            Dictionary<int, string> list = new Dictionary<int, string>(6);

            using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
            {
                foreach (string i in text)
                {
                    sw.WriteLine(i);
                }
            }

            using (StreamReader sr = new StreamReader(writePath, Encoding.Default))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(i++, line);
                }
            }

            foreach (KeyValuePair<int, string> keyValue in list)
            {
                WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            */

            //Task 2

            /*
            FileStream file = File.Create(@"numbers.bin");
            BinaryWriter writer = new BinaryWriter(file);

            double[] numbers = { 10.3, 10.6, 10.5, 10.3, 10.4 };
            foreach (double i in numbers)
            {
                writer.Write(i);
            }
            writer.Close();

            WriteLine("\n\nEnd...");
            ReadKey();
            */


            //Task 3

            /*
            bool b = true;
            int i1 = 21;
            double d = 6.9;

            var list = new ArrayList();
            List<bool> blist = new List<bool>();
            List<int> ilist = new List<int>();
            List<double> dlist = new List<double>();

            list.Add(b);
            list.Add(i1);
            list.Add(d);

            using (StreamWriter sw = new StreamWriter(@"\ArrayList.txt"))
            {
                foreach (var item in list)
                {
                    sw.Write(item);
                }
            }

            using (StreamReader sr = new StreamReader(@"\ArrayList.txt"))
            {
                if (sr.GetType() == b.GetType())
                {
                    b = bool.Parse(sr.ReadLine());
                    blist.Add(b);
                }
                else if (sr.GetType() == i1.GetType())
                {
                    i1 = int.Parse(sr.ReadLine());
                    ilist.Add(i1);
                }
                else if (sr.GetType() == b.GetType())
                {
                    d = double.Parse(sr.ReadLine());
                    dlist.Add(d);
                }
                else
                {
                    sr.ToString();
                }
            }

            WriteLine("\n\nEnd...");
            ReadKey();
            */



            //Task 4


            /*  DEMO FILE MANAGER
            DriveInfo[] drives = DriveInfo.GetDrives();

            for (int i = 0; i < drives.Length; i++)
            {
                WriteLine($"[{i + 1}] - {drives[i].Name}");
            }

            int choice = int.Parse(ReadLine()) - 1;
            string location = drives[choice].Name;

            do
            {
                Clear();
                var dir = new DirectoryInfo(location);

                WriteLine($"Name: \t\t\t|{dir.Name}");
                WriteLine($"Directory: \t\t|{dir.FullName}");
                WriteLine($"Extension: \t\t|{dir.Extension}");
                WriteLine($"Creationtime: \t\t|{dir.CreationTime}");
                WriteLine($"LastWriteTime: \t\t|{dir.LastWriteTime}");
                WriteLine($"LastAccessTime: \t|{dir.LastAccessTime}");

                WriteLine("____________________________________________\n");
                ForegroundColor = ConsoleColor.Cyan;
                foreach (var d in dir.GetDirectories())
                {
                    WriteLine($"Name: \t\t\t|{d.Name}");
                    WriteLine($"Directory: \t\t|{d.FullName}");
                    WriteLine($"Extension: \t\t|{d.Extension}");
                    WriteLine($"Creationtime: \t\t|{d.CreationTime}");
                    WriteLine($"LastWriteTime: \t\t|{d.LastWriteTime}");
                    WriteLine($"LastAccessTime: \t|{d.LastAccessTime}");
                    WriteLine();  
                }

                ResetColor();
                Write($@"{location}\");
                string location2 = ReadLine();
                string nextLocation = Path.Combine(location, location2);
                location = nextLocation;


                ReadKey();


            } while (true);
            */

            /*
            DriveInfo[] drives = DriveInfo.GetDrives();

            for (int i = 0; i < drives.Length; i++)
            {
                WriteLine($"[{i + 1}] - {drives[i].Name}");
            }

            int choice = int.Parse(ReadLine()) - 1;
            string location = drives[choice].Name;

            do
            {
                Clear();
                WriteLine("");
                var dir = new DirectoryInfo(location);
                WriteLine($"═══════════════════════{dir.FullName}═══════════════════════\n");
                foreach (var d in dir.GetDirectories())
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("[" + d.Name + "]");
                }
                foreach (var f in dir.GetFiles())
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine(f.Name);
                }

                ResetColor();
                Write($@"{location}\");
                string location2 = ReadLine();
                string nextLocation = Path.Combine(location, location2);

                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Directory:\t[1] - Create; [2] - Delete; [3] - Rename; [Enter] - Open");
                WriteLine("File:\t\t[F1] - Create; [F2] - Delete; [F3] - Rename;");
                ResetColor();
                switch (ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            Directory.CreateDirectory(nextLocation);
                            break;
                        }
                    case ConsoleKey.F1:
                        {
                            File.Create(nextLocation);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            WriteLine("\nReally delete?\n[Yes]/[No]");
                            string key = ReadLine();
                            if (key == "Yes")
                            {
                                Directory.Delete(nextLocation);
                            }
                            if (key == "No")
                            {
                                location = nextLocation;
                            }
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            WriteLine("\nReally delete?\n[Yes]/[No]");
                            string key = ReadLine();
                            if (key == "Yes")
                            {
                                File.Delete(nextLocation);
                            }
                            if (key == "No")
                            {
                                location = nextLocation;
                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Write("\nEnter new folder name: ");
                            string newName = ReadLine();
                            Directory.Move(nextLocation, Path.Combine(location, newName));
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Write("\nEnter new file name: ");
                            string newName = ReadLine();
                            File.Move(nextLocation, Path.Combine(location, newName));
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            location = nextLocation;
                            break;
                        }
                    default:
                        {
                            location = nextLocation;
                            break;
                        }     
                }

            } while (true);
            

            WriteLine("\n\nEnd...");
            ReadKey();
            */

        } //--------------------Main--------------------↑







    }  //--------------------Program--------------------↑
} //--------------------Namespace-------------------↑
