using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_ex3
{
    // Дубровский Вячеслав
    // 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //Например:
    //badc являются перестановкой abcd.
    class HomeWork3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку 1");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите строку 2");
            string s2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x)) ? "Является" : "Не является");
            Console.ReadLine();
        }
    }

}
