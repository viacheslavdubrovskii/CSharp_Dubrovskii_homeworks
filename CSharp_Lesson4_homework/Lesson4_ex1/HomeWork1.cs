using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ex1
{
    // Дубровский Вячеслав

    //1.  Дан  целочисленный  массив  из 20 элементов.  
    //Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
    //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива,
    //в которых только одно число делится на 3. 
    //В данной задаче под парой подразумевается два подряд идущих элемента массива. 
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
    class MyArray
    {
        int[] a;
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(min, max);
            }
        }
        static bool Odd(int m)
        {
            return m % 3 == 0;
        }

        public int Pair
        {
            get
            {
                int pair = 0;
                for (int i = 0; i < a.Length; i++)
                    try
                    {
                        if (Odd(a[i]) & Odd(a[i+1])) pair++;
                    }
                    catch (Exception)
                    {
                        return pair;
                    }
                return pair;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int number in a)
                s = s + number+ " ";
            return s;
        }
        class HomeWork1
        {
            static void Main(string[] args)
            {
                MyArray a = new MyArray(20, -10000, 10001);
                Console.WriteLine(a.ToString());
                Console.WriteLine($"Количество пар элементов массива: { a.Pair}");

                Console.ReadLine();
            }
        }
    }
}

