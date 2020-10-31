using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1_ex3_meth1;

namespace Lesson1_ex3_meth1
{
    public class Solution
    {
        public static void meth1()
        {
            Console.WriteLine("Введите значение координаты х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение координаты y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение координаты х2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение координаты y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Найдем расстояние между точками по формуле указанной в задании");
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние равно " + "{0:F2}", r);
            Console.ReadLine();
        }
    }
}
