using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Lesson3_ex1.HomeWork1;

namespace Lesson3_ex1
{
    // Дубровский Вячеслав
    class HomeWork1
    {
        // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
        // Продемонстрировать работу структуры;
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
        struct Complex
        {
            public double im;
            public double re;
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }
        public class SwitchClass
        {
            // Хотел добавить класс SwitchClass, и создать в нем случайно генерируемую переменную caseSwitch, а потом
            // обратиться из Programm, чтобы эту переменную вызвать. Подскажите, как мне нужно дописать программу, чтобы
            // все получилось?

            public int caseSwitch;
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Ввод первого комплексного числа
                Complex complex1;
                complex1.re = 3;
                complex1.im = 4;
                // Ввод второго комплексного числа
                Complex complex2;
                complex2.re = 2;
                complex2.im = 1;

                Complex resultplus = complex1.Plus(complex2);
                Console.WriteLine("Результат суммы комплексных чисел : " + resultplus.ToString());
                Console.ReadLine();
                Complex resultminus = complex1.Minus(complex2);
                Console.WriteLine("Результат вычитания комплексных чисел : " + resultminus.ToString());
                Console.ReadLine();
                Complex resultmulti = complex1.Multi(complex2);
                Console.WriteLine("Результат умножения комплексных чисел : " + resultmulti.ToString());
                Console.ReadLine();

                SwitchClass caseSwitch;
                // в) Добавить диалог с использованием switch демонстрирующий работу класса.

                Random rnd = new Random();

                switch (rnd.Next(0, 3))
                {
                    case 1:
                        Console.WriteLine("Первый случай - 1");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Второй случай - 2");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Третий случай - 3");
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}
        
