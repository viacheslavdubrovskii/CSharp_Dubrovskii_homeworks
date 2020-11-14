using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_ex1
{ 
// Дубровский Вячеслав

// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

delegate double Function(double a, double x);

class HomeWork1
{

    static void Plot(Function function, int min, int max)
    {
        Console.WriteLine($"x      |y    ");
        double a = 2;
        for (double x = min; x < max; x += 0.5)
        {
            Console.WriteLine($"{x,-7}|{function(a, x):F2} ");
        }
    }
    static double ReturnAX(double a, double x)
    {
        return a * x * x;
    }
    static double ReturnASinX(double a, double x)
    {
        return a * Math.Sin(x);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Функция а * х^2:");
        Plot(ReturnAX, -3, 3); Console.WriteLine("\n-------\n");
        Console.WriteLine("Функция а * sin(x):");
        Plot(ReturnASinX, -3, 3); Console.WriteLine("\n-------\n");
        Console.ReadLine();

    }
}
}