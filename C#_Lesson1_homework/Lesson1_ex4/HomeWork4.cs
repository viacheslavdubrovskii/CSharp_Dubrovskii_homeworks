using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_ex4
{
    class HomeWork4
    {
        // Дубровский Вячеслав
        static void Main(string[] args)
        {
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;

            int a;
            Console.WriteLine("Введите переменную а");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите переменную а (целое число)");
            }
            int b;
            Console.WriteLine("Введите переменную b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите переменную b (целое число)");
            }
            Console.WriteLine("Сейчас а = " + a + ", и b = " + b);
            Console.ReadLine();
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("А теперь а = " + a + ", и b = " + b);
            Console.ReadLine();
            // б) *без использования третьей переменной;
            Console.WriteLine("Введите переменную а1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную b1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сейчас а1 = " + a1 + ", и b1 = " + b1);
            Console.ReadLine();
            a1 = a1 + b1;
            b1 = b1 - a1;
            b1 = -b1;
            a1 = a1 - b1;
            Console.WriteLine("А теперь а1 = " + a1 + ", и b1 = " + b1);
            Console.ReadLine();
        }
    }
}
