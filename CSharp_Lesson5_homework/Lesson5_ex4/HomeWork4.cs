using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_ex4
{
    struct Element
    {
        public string FIO;
        public int n1;
        public int n2;
        public int n3;
    }
    class HomeWork4
    {
        // Дубровский Вячеслав

        // 4. *Задача ЕГЭ.
        // Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена
        // трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
        // набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HOME\Desktop\Програмирование\C#\GeekBrains Homeworks\CSharp_Lesson5_homework\data.txt");
            int N = int.Parse(sr.ReadLine());
            Element[] a = new Element[N];
            for (int i =0; i<N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].FIO = s[0] + s[1];
                a[i].n1 = int.Parse(s[2]);
                a[i].n2 = int.Parse(s[3]);
                a[i].n3 = int.Parse(s[4]);
                // Считываю данные с файла data.txt в 4 массива - 1 с фамилией и именем, и 3 с оценками
            }
            sr.Close();
            double[] massiv = new double[N+1];
            for (int i = 0;i<N; i++)
            {
                massiv[(a[i].n1 + a[i].n2 + a[i].n3) / 3]++;
                // Создаю массив, в котором будет хранится среднее арифметическое всех оценок
            }
            double min1 = 13 / 3;
            double min2 = 14 / 3;
            double min3 = 16;
            // Создаю 3 переменных с максимально возможными минимальными средними арифметическими оценок
            for (int i = 0; i < N; i++)
            {
                if (massiv[i] <= min3 && massiv[i] > min2) min3 = massiv[i];
                if (massiv[i]<min3 && massiv[i]<=min2 &&massiv[i]>min1) min2 = massiv[i];
                if (massiv[i] < min3 && massiv[i] < min2 && massiv[i] <= min1) min1 = massiv[i];
                // Сравниваю каждый элемент massiv с min1, min2 и min3
            }
            for (int i = 0; i < 15; i++)
            {
                if (massiv[i] == min3 || massiv[i] == min2 || massiv[i]== min1) Console.WriteLine(a[i].FIO);
                // В min1, min2 и min3 теперь должны лежать три минимальных средних арифметических оценок.
                // Вывожу массивы FIO, имеющие тот же i, что и min1, min2 и min3
            }
            Console.ReadLine();
        }
    }
}
