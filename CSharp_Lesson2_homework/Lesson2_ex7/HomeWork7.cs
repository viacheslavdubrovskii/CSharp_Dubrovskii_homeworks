using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex7
{
    class HomeWork7
    {
        // Дубровский Вячеслав
        // 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)
        static void Loop(int a, int b)
        {
            Console.Write("{0,3} ", a);
            if (a < b) Loop(a + 1, b);
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число а");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите целое число а");
            }
            int b;
            Console.WriteLine("Введите число b, которое больше а");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите целое число b, которое больше а");
            }
            if (a < b)
            {
                Loop(a, b);
            }
            else
            {
                Console.WriteLine("Число b должно было быть больше а. Не буду ничего выводить.");
            }
            Console.ReadLine();

        }
    }
}
