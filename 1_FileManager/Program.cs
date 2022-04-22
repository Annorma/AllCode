using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using static System.Console;

namespace _1_FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var fm = new FileManager();
            string[] disks = Environment.GetLogicalDrives();

            for (int i = 0; i < disks.Length; i++)
            {
                fm.AddItem(disks[i]);
            }
            fm.Show();
            fm.Menu();

            WriteLine("\n\nEnd...");
            ReadKey();

        }//--------------------Main--------------------↑



        class DeviceException : ApplicationException
        {
            public DeviceException() : base("This device does NOT respond or does NOT work!") { }
        }
        class FileManager
        {
            private string MenuItem;
            private List<string> list = new List<string>();
            DirectoryInfo di;
            private bool press_enter = false;
            private int current = 0;
            private string path_current;
            private int tmp = 0;
            ConsoleKeyInfo KeyPress = new ConsoleKeyInfo();
            ConsoleKeyInfo DeleteKeyPress = new ConsoleKeyInfo();
            public void AddItem(string MenuItem)
            {
                this.MenuItem = MenuItem;
                list.Add(MenuItem);
            }
            public void Set_show(int current)
            {
                ResetColor();
                SetCursorPosition(0, current);
                Write(list[current]);

            }
            public bool Find_Dirictories()
            {
                int count = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].StartsWith("[") && list[i].EndsWith("]")) { count++; }
                }
                if (count > 0) { return true; }
                else { return false; }
            }
            public void SetColor()
            {
                ForegroundColor = ConsoleColor.Green;
            }
            public void Show_files_dirictories() //вивід папок і файлів
            {
                DirectoryInfo[] dirAll = di.GetDirectories();
                FileInfo[] fileAll = di.GetFiles();
                list.Clear();
                list.Add("..");
                for (int i = 0; i < dirAll.Length; i++) //для папок
                {
                    list.Add("[" + dirAll[i].ToString() + "]");
                }
                for (int i = 0; i < fileAll.Length; i++) //для файлів
                {
                    list.Add(fileAll[i].ToString());
                }
                list.Add("{Create new folder}");
                list.Add("{Create new file}");
                Clear(); //очищуємо 
                current = 0; //поточна позиція в нуль
                Show(); //показуємо все
            }
            public void Show()
            {
                CursorVisible = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        SetColor();
                        WriteLine(list[i]);
                    }
                    else
                    {
                        ResetColor();
                        WriteLine(list[i]);
                    }
                }
            }
            public void Menu()
            {
                while (true)
                {
                    KeyPress = ReadKey();
                    switch (KeyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                press_enter = false; //ентер не натиснений
                                if (press_enter) //якщо натиснули ентер, то очищуємо консоль і показуємо директорію
                                {
                                    Clear();
                                    Show();
                                    Menu();
                                }
                                if (current != 0) //якщо поточна позиціє не нуль, то преміщуємо курсор вище і показуємо
                                {
                                    Set_show(current);
                                    current--;
                                }
                                else //якщо нуль и натиснули вгору, то переміщуємо на останню позицію
                                {
                                    Set_show(current);
                                    current = list.Count - 1;
                                }
                                SetCursorPosition(0, current);
                                SetColor();
                                Write(list[current]);
                                break;
                            }
                        case ConsoleKey.DownArrow: //те саме для нижньої стрілки
                            {
                                press_enter = false;
                                if (press_enter)
                                {
                                    Clear();
                                    Show();
                                    Menu();
                                }
                                if (current != list.Count - 1)
                                {
                                    Set_show(current);
                                    current++;
                                }
                                else
                                {
                                    Set_show(current);
                                    current = 0;
                                }
                                SetCursorPosition(0, current);
                                SetColor();
                                Write(list[current]);
                                break;
                            }
                        case ConsoleKey.Enter: //при натиснені ентеру
                            {
                                press_enter = true;
                                if (list[current].StartsWith("[") && list[current].EndsWith("]")) //якщо папка
                                {
                                    path_current += list[current].Substring(1, list[current].Length - 2) + "\\";
                                    di = new DirectoryInfo(path_current);
                                    tmp++;
                                    Show_files_dirictories();
                                }
                                else if (list[current].Equals("..")) //перехід вище на каталог
                                {
                                    if (tmp == 1) //якщо вище є диски
                                    {
                                        Clear();
                                        string[] disks = Environment.GetLogicalDrives();
                                        list.Clear();
                                        for (int i = 0; i < disks.Length; i++)
                                        {
                                            list.Add(disks[i]);

                                        }
                                        path_current = " ";
                                        tmp--;
                                        Show();
                                        Menu();
                                    }
                                    if (tmp > 1) //якщо немає дисків
                                    {
                                        path_current = path_current.Remove(path_current.Length - 2);
                                        path_current = path_current.Remove(path_current.LastIndexOf(@"\") + 1);
                                        di = new DirectoryInfo(path_current);
                                        tmp--;
                                        Show_files_dirictories();
                                    }
                                }
                                else if (list[current].Equals("{Create new folder}")) //створення нової папки
                                {
                                    Clear();
                                    ResetColor();
                                    Write("Enter new folder name: ");
                                    string name = ReadLine();
                                    path_current = Path.Combine(path_current, name);
                                    if (name != null && name != "" && name != " ")
                                    {
                                        Directory.CreateDirectory(path_current);
                                        Clear();
                                        di = new DirectoryInfo(path_current);
                                        tmp++;
                                        Show_files_dirictories();
                                    }
                                    else { Clear(); Show_files_dirictories(); };
                                }
                                else if (list[current].Equals("{Create new file}")) //створення нового файлу
                                {
                                    Clear();
                                    ResetColor();
                                    Write("Enter new file name: ");
                                    string name = ReadLine();
                                    string temp = path_current;
                                    path_current = Path.Combine(path_current, name);
                                    if (name != null && name != "" && name != " ")
                                    {
                                        FileStream file = File.Create(path_current);
                                        file.Close();
                                        path_current = temp;
                                        Clear();
                                        Show_files_dirictories();
                                    }
                                    else { Clear(); Show_files_dirictories(); }
                                }
                                else if (tmp > 0) //відкриття файлу
                                {
                                    string tmp = path_current;
                                    path_current = Path.Combine(path_current, list[current]);
                                    path_current = path_current.Trim();
                                    Process.Start(path_current);
                                    path_current = tmp;
                                }
                                else //перехід для дисків
                                {
                                    path_current += list[current];
                                    di = new DirectoryInfo(path_current);
                                    tmp++;
                                    Show_files_dirictories();
                                }
                                break;
                            }
                        case ConsoleKey.R: //при натиснені "R" (перейменовує)
                            {
                                if (list[current].StartsWith("[") && list[current].EndsWith("]")) //якщо папка
                                {
                                    string location = path_current;
                                    Clear();
                                    ResetColor();
                                    Write("\nRename folder: ");
                                    string newName = ReadLine();
                                    path_current = Path.Combine(path_current, list[current].Substring(1, list[current].Length - 2));
                                    Directory.Move(path_current, Path.Combine(location, newName));
                                    di = new DirectoryInfo(Path.Combine(location, newName));
                                    tmp++;
                                    Show_files_dirictories();
                                }
                                else if (tmp > 0) //якщо файл
                                {
                                    string location = path_current;
                                    Clear();
                                    ResetColor();
                                    Write("\nRename file: ");
                                    string newName = ReadLine();
                                    path_current = Path.Combine(path_current, list[current]);
                                    File.Move(path_current, Path.Combine(location, newName));
                                    Clear();
                                    path_current = location;
                                    Show_files_dirictories();
                                }
                                break;
                            }
                        case ConsoleKey.Delete: //при натиснені "Delete" (видаляє)
                            {
                                if (list[current].StartsWith("[") && list[current].EndsWith("]")) //якщо папка
                                {
                                    string location = path_current;
                                    Clear();
                                    ResetColor();
                                    Write("\nRealy delete?\n[Y]/[N]\n");
                                    DeleteKeyPress = ReadKey();
                                    if (DeleteKeyPress.Key == ConsoleKey.Y)
                                    {
                                        path_current = Path.Combine(path_current, list[current].Substring(1, list[current].Length - 2));
                                        Directory.Delete(path_current, true);
                                        Clear();
                                        path_current = location;
                                        Show_files_dirictories();
                                    }
                                    if (DeleteKeyPress.Key == ConsoleKey.N)
                                    {
                                        Clear();
                                        di = new DirectoryInfo(location);
                                        Show_files_dirictories();
                                    }
                                }
                                else if (tmp > 0) //якщо файл
                                {
                                    string location = path_current;
                                    Clear();
                                    ResetColor();
                                    Write("\nRealy delete?\n[Y]/[N]\n");
                                    DeleteKeyPress = ReadKey();
                                    if (DeleteKeyPress.Key == ConsoleKey.Y)
                                    {
                                        path_current = Path.Combine(path_current, list[current]);
                                        File.Delete(path_current);
                                        Clear();
                                        path_current = location;
                                        Show_files_dirictories();
                                    }
                                    if (DeleteKeyPress.Key == ConsoleKey.N)
                                    {
                                        Clear();
                                        di = new DirectoryInfo(location);
                                        Show_files_dirictories();
                                    }
                                }
                                break;
                            }
                        default:
                            {
                                Clear();
                                Show();
                                SetCursorPosition(0, current);
                                SetColor();
                                Write(list[current]);
                                break;
                            }

                    } //--------------------Switch--------------------↑
                } //--------------------While--------------------↑
            } //--------------------Void Perem--------------------↑
        } //--------------------Class FileManager--------------------↑







    } //--------------------Program--------------------↑
} //--------------------Namespace-------------------↑
