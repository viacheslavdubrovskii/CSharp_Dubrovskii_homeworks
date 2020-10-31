using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_ex5
{
    // Дубровский Вячеслав
    // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    //нужно ли человеку похудеть, набрать вес или всё в норме.

    class HomeWork5
    {
        static void Main(string[] args)
        {
            double weight;
            Console.WriteLine("Введите массу человека (кг)");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Введите массу человека (кг)");
            }
            double height;
            Console.WriteLine("Теперь введите рост человека (в см)");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Введите рост человека (в см)");
            }
            double bmi = weight / Math.Pow(height, 2);
            bmi = bmi * 10000;
            Console.WriteLine($"Ваш индекс массы тела (ИМТ) равен {bmi}");
            if (bmi <= 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
                Console.ReadLine();
            }
            if (16 < bmi & bmi <= 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
                Console.ReadLine();
            }
            if (18.5 < bmi & bmi <= 25)
            {
                Console.WriteLine("У вас все норм");
                Console.ReadLine();
            }
            if (25 < bmi & bmi <= 30) {
                Console.WriteLine("Предожирение");
                Console.ReadLine();
            }
            else { 
                Console.WriteLine("Худей!");
                Console.ReadLine(); }
        }
        }
    }
