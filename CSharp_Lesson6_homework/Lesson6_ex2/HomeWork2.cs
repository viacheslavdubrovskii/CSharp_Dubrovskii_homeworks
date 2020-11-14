using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson6_ex2
{
    // Дубровский Вячеслав

    // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
    //  а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //  Использовать массив(или список) делегатов, в котором хранятся различные функции.

    delegate double Function(double x);
    delegate void FunctionTest(string fileName, double a, double b, double h, Function F);

    class HomeWork2
    {
            public static double F1(double w)
        {
            return w;
        }
        public static double F2(double x)
        {
            return x / 2;
        }
        public static double F3(double x)
        {
            return Math.Sin(x);
        }
        static void SaveFunc(string fileName, double a, double b, double h, Function F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {

            // Хотел обратиться к test [0] и записать SaveFunc в файл data.bin c функцией F1 способом ниже,
            // но вышло слишком сложно и запутался.

            //FunctionTest[] test = new FunctionTest[3];
            //FunctionTest first = SaveFunc;
            //test[0] = first;
            //test[0](new HomeWork2(SaveFunc("data.bin", from, to, step, F1))



            Console.WriteLine("Введите первую границу для функции");
            int from;
            int to;
            int step;
            int choice;
            while (!int.TryParse(Console.ReadLine(), out from))
            {
                Console.WriteLine("Введите первую границу для функции (число)");

            }
            Console.WriteLine("Введите вторую границу для функции");
            while (!int.TryParse(Console.ReadLine(), out to))
            {
                Console.WriteLine("Введите вторую границу для функции (число)");

            }
            Console.WriteLine("Введите шаг");
            while (!int.TryParse(Console.ReadLine(), out step))
            {
                Console.WriteLine("Введите шаг (число)");

            }
            Console.WriteLine("Введите номер функции которую хотите посчитать: \n 1 - для х*х \n 2 - для х/2 \n 3 - для sin (x)");
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Введите ЧИСЛО");
            }

            switch (choice)
            {
                case 1:
                    SaveFunc("data.bin", from, to, step, F1);
                    Console.WriteLine($"Минимум функции х*х на интервале от {from} до {to} равен");
                    Console.WriteLine(Load("data.bin"));
                    Console.ReadKey();
                    break;
                case 2:
                    SaveFunc("data.bin", from, to, step, F2);
                    Console.WriteLine($"Минимум функции х/2 на интервале от {from} до {to} равен");
                    Console.WriteLine(Load("data.bin"));
                    Console.ReadKey();
                    break;
                case 3:
                    SaveFunc("data.bin", from, to, step, F3);
                    Console.WriteLine($"Минимум функции sin (x) на интервале от {from} до {to} равен");
                    Console.WriteLine(Load("data.bin"));
                    Console.ReadKey();
                    break;
            }
        }

    }
}
