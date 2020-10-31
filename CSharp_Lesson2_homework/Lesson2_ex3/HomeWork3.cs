using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex3
{
    // Дубровский Вячеслав
    class HomeWork3
    {
        static bool Odd(int a)
        {
            return a % 2 == 1;
        }

        // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            int numb = 2;
            int sum = 0;
            for ( ;numb !=0; )
            {
                Console.WriteLine("Введите число");
                while (!int.TryParse(Console.ReadLine(), out numb))
                {
                    Console.WriteLine("Введите ЧИСЛО");
                }

                if ((numb > 0 & Odd(numb)))
                {
                    sum = sum + numb;
                }
            }
                    Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}");
                    Console.ReadLine();
        }
    }
}
