using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ex3
{
    // Дубровский Вячеслав
    // а) Дописать класс для работы с одномерным массивом.
    //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения
    //с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
    //возвращающий новый массив с измененными знаками у всех элементов массива
    //(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число,
    //свойство MaxCount, возвращающее количество максимальных элементов. 

    class MyArray
    {
        int[] a;
        public MyArray(int volume, int start, int step)
        {
            a = new int[volume];
            a[0] = start;
            for (int i = 1; i < volume; i++)
            {
                a[i] = a[0] + step * i;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int number in a)
                s = s + number + " ";
            return s;
        }
        public int Summ()
        {
            int sum = 0;
            foreach (int value in a)
            {
                sum += value;
            }
            return sum;
        }
        public string Inverse()
        {
            string s = "";
            foreach (int number in a)
                s = s + number *(-1) + " ";
            return s;
        }
        public string Change()
        {
            string s = "";
            foreach (int number in a)
                s = s + number * 2 + " ";
            return s;
        }
        public int MaxCount
        {
            get
            {
                int imax = a[0];
                int MaxCount = 1;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > a[imax]) MaxCount = 1;
                    else if (a[i] == imax) MaxCount++;
                return MaxCount;
            }
        }


        class HomeWork3
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите размер массива");
                int volume = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите начальное значение массива");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите шаг массива");
                int step = Convert.ToInt32(Console.ReadLine());
                MyArray a = new MyArray(volume, start, step);
                Console.WriteLine($"Массив: {a.ToString()}");
                Console.ReadLine();
                Console.WriteLine($"Сумма элементов массива: {a.Summ()}");
                Console.ReadLine();
                Console.WriteLine($"Массив с измененными знаками: {a.Inverse()}");
                Console.ReadLine();
                Console.WriteLine($"Массив в котором каждое число умножено на 2 : {a.Change()}");
                Console.ReadLine();
                Console.WriteLine($"Количество максимальных элементов массива : {a.MaxCount}");
                Console.ReadLine();
            }
        }
    }
}
