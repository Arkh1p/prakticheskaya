using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("1. Регистрация\n2. Авторизация");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: reg();
                    break;
                case 2: log();
                    break;
            }

            Console.ReadKey();
        }

        static void reg()
        {
            Console.Clear();

            Console.WriteLine("Введите логин: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string c = Console.ReadLine();
            string d = (string)(b + c);

            using (FileStream file2 = new FileStream(@"C:\\Users\Roma\Desktop\new_file.txt", FileMode.Open))
                {
                    StreamWriter writer = new StreamWriter(file2);
                    writer.Write(d);
                    writer.Close();
                }
            Console.WriteLine("Регистрация совершена");
            Console.ReadKey();
        }

        static void log()
        {
            Console.Clear();

            Console.WriteLine("Введите логин: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string c = Console.ReadLine();
            string d = (string)(b + c);

            using (FileStream file1 = new FileStream(@"C:\\Users\Roma\Desktop\new_file.txt", FileMode.Open))
            {
                StreamReader reader = new StreamReader(file1);
                
                

                if (d == reader.ReadToEnd())
                {
                    Console.WriteLine("Авторизация успешна");
                }
                else
                {
                    Console.WriteLine("Ошибка авторизации");
                    
                }
                
            }
            Console.ReadKey();

        }
    }
}
