using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_ex3
{
    // Дубровский Вячеслав
    // 3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    // Написать программу, демонстрирующую все разработанные элементы класса.
    class HomeWork3
    {
        struct Fraction
        {
            public int numerator;
            public int denominator;
            public Fraction Multi (Fraction x)
            {
                Fraction y;
                y.numerator = numerator * x.numerator;
                y.denominator = denominator * x.denominator;
                return y;
            }
            public Fraction Plus(Fraction x)
            {
                Fraction y;
                y.numerator = numerator * x.denominator + x.numerator * denominator;
                y.denominator = denominator * x.denominator;
                return y;
            }
            public Fraction Minus (Fraction x)
            {
                Fraction y;
                y.numerator = numerator * x.denominator - x.numerator * denominator;
                y.denominator = denominator * x.denominator;
                return y;
            }
            public Fraction Division (Fraction x)
            {
                Fraction y;
                y.numerator = numerator * x.denominator;
                y.denominator = denominator * x.numerator;
                return y;
            }
            public string ToString()
            {
                return numerator + "/" + denominator;
            }
        }
        static void Main(string[] args)
        {
            // * Добавить свойства типа int для доступа к числителю и знаменателю;

            // Ввод первой дроби

            Fraction frac1;
            Console.WriteLine("Введите числитель первой дроби");
            frac1.numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            frac1.denominator = int.Parse(Console.ReadLine());

            // Ввод второй дроби

            Fraction frac2;
            Console.WriteLine("Введите числитель второй дроби");
            frac2.numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            frac2.denominator = int.Parse(Console.ReadLine());

            // Вывод

            Fraction resultmulti = frac1.Multi(frac2);
            Console.WriteLine("Результат умножения дробей : " + resultmulti.ToString());
            Console.ReadLine();
            Fraction resultplus = frac1.Plus(frac2);
            Console.WriteLine("Результат сложения дробей : " + resultplus.ToString());
            Console.ReadLine();
            Fraction resultminus = frac1.Minus(frac2);
            Console.WriteLine("Результат разности дробей : " + resultminus.ToString());
            Console.ReadLine();
            Fraction resultdivision = frac1.Division(frac2);
            Console.WriteLine("Результат деления дробей : " + resultdivision.ToString());
            Console.ReadLine();

        }
    }
}
