using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_ex2
{
    // Дубровский Вячеслав
    class HomeWork2
    {
        static bool Odd(int a)
        {
            return a % 2 == 1;
        }

        // а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечётных положительных чисел. 
        //Сами числа и сумму вывести на экран, используя tryParse.
        static void Main(string[] args)
        {
            int numb = 2;
            int sum = 0;
            for (; numb != 0;)
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