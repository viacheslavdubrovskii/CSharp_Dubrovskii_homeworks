using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson5_ex1
{
    // Дубровский Вячеслав
    // 1. Создать программу, которая будет проверять корректность ввода логина. 
    // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
    // при этом цифра не может быть первой:
    // а) без использования регулярных выражений
    class HomeWork1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин (2-10 символов)");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            bool check = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Length > 2 & a.Length < 10 & char.IsLetterOrDigit(a[i]))
                {
                    if (char.IsDigit(a[0]))
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                else
                {
                    check = false;
                }
            }
            Console.WriteLine(check == true ? "Логин введен корректно" : "Логин введен некорректно");
            Console.ReadLine();

            // 2б) **с использованием регулярных выражений.

            //Regex myReg = new Regex(@"\D[А-яa-z0-9]{1,9}", RegexOptions.IgnoreCase);
            //Console.WriteLine(myReg.IsMatch(Console.ReadLine()) ? "Логин введен корректно" : "Логин введен некорректно");
            //Console.ReadLine();

            //  Я пытался =(

        }
    }
}
