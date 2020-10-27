using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubrovskii_25_10
{
    class HomeWork1
    {
        // Дубровский Вячеслав
        static void Main(string[] args)
        {
            //1.Написать программу «Анкета».
            //а) используя склеивание;
            Console.WriteLine("Программа \"Анкета\"");
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас рост? (см)");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас вес? (кг)");
            int weight = Convert.ToInt32(Console.ReadLine());
            string result = ("Анкета:\n Меня зовут " + name + " " + surname + ". Мне " + age + " лет. Мой рост " + height + " см, а вес " + weight + " кг");
            Console.WriteLine(result);
            Console.ReadLine();
            //б) используя форматированный вывод;
            Console.WriteLine("Имя: {0, 10} | Фамилия: {1, 10} | Возраст: {2, 10} | Рост (см): {3, 10} | Вес(кг): {4, 10} \n", name, surname, age, height, weight.ToString());
            // в) используя вывод со знаком $;
            Console.WriteLine($"Имя: {name} | Фамилия: {surname} | Возраст: {age} | Рост (см): {height} | Вес(кг): {weight} ");
            Console.ReadLine();

        }
    }
}
