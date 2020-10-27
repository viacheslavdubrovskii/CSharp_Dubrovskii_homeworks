using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubrovskii_25_10
{
    class HomeWork2
    {
        // Дубровский Вячеслав
        static void Main(string[] args)
        {
            // Ввести вес и рост человека. 
            // Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            double weight;
            Console.WriteLine("Введите вес человека");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Введите вес человека");
            }
            Console.WriteLine("Вы ввели массу человека, а не вес. Но ИМТ я все равно посчитаю");
            double height;
            Console.WriteLine("Теперь введите рост человека (в метрах)");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Введите рост человека (в метрах)");
            }
            double bmi = weight / Math.Pow (height, 2);
            Console.WriteLine("Ваш индекс массы тела (ИМТ) = " + bmi);
            Console.ReadLine();

        }
    }
}
