using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Введите 2 одиноковых числа");
                Console.Write("Введите M ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Введите N ");
                m = int.Parse(Console.ReadLine());
                int[,] array1 = new int[m, n];
                int[,] array2 = new int[m, n];
                if (m == n)
                {
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            array1[x, y] = rnd.Next(1, 20);
                            Console.Write(array1[x, y]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Зеркальная матрица");
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            array2[x, y] = array1[(n - 1) - x, y];
                            Console.Write(array2[y, x]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Завершено");
                    Console.ReadKey();
                }
                if (m != n)
                {
                    Console.WriteLine("Вы ввели неправильные числа!\n");
                }

            }
        }
    }
}
