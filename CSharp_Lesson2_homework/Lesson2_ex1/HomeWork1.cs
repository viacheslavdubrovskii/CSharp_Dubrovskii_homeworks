using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex1
{
    // Дубровский Вячеслав
    class HomeWork1
    {
        static void Main(string[] args)
        {
            // 1. Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = int.Parse(Console.ReadLine());
            int aorb = a < b ? a : b;
            int min = aorb < c ? aorb : c;
            Console.WriteLine($"Минимальное число - {min}");
            Console.ReadKey();

        }
    }
}
