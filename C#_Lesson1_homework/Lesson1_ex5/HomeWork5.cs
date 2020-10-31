using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_ex5
{
    class HomeWork5
    {
        // Дубровский Вячеслав
        static void Main(string[] args)
        {
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите город проживания");
            string city = Console.ReadLine();
            Console.WriteLine($" Имя: {name} | Фамилия: {surname} | Город проживания: {city}");
            Console.ReadLine();
            // б) *Сделать задание, только вывод организовать в центре экрана.
            var width = Console.WindowWidth;
            var padding = width / 2;
            Console.WriteLine("{0," + padding + "}", "Имя: " + name + " Фамилия: " + surname + " Город: " + city);
            Console.ReadLine();
        }
    }
}
