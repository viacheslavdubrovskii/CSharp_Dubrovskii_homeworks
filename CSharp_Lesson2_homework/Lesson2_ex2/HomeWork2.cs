using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex2
{
    // Дубровский Вячеслав
    class HomeWork2
    {
        static void Main(string[] args)
        {
            // 2. Написать метод подсчета количества цифр числа.
            Console.WriteLine("Введите число, в котором нужно посчитать цифры");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите ЧИСЛО");
            }
            int count = 0;
            while (x != 0)
            {
                count++;
                x = x / 10;	
            }
            if (count == 1) 
            Console.WriteLine($"В введенном вами числе {count} цифра");
            else if (count == 2| count == 3 | count ==4)
            Console.WriteLine($"В введенном вами числе {count} цифры");
            else Console.WriteLine($"В введенном вами числе {count} цифр");
            Console.ReadKey();

        }
    }
}
