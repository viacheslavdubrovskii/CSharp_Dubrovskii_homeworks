using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex4
{
    class HomeWork4
    {
        // Дубровский Вячеслав
        //4.  Реализовать метод проверки логина и пароля.
        //    На вход метода подается логин и пароль.
        //    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
        //    программа пропускает его дальше или не пропускает.
        //    С помощью цикла do while ограничить ввод пароля тремя попытками.


        static void Main(string[] args)
        {
            int x = 0;
            
            do {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                if (login == "root" & password == "GeekBrains")
                {
                    Console.WriteLine("Добро пожаловать");
                    x = x + 10;
                    Console.ReadLine();
                } else
                {
                    x = x + 1;
                    Console.WriteLine($"Неверный логин или пароль. Число оставшихся попыток: {3 - x}");
                }

            } while (x <3);
        }
    }
}
