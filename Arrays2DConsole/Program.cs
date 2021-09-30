using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleRead;
            int n, m;
            double[,] array;

            double[] result;
            double[] arraySortedRows;

            Console.WriteLine("Лабораторна робота №3");
            Console.WriteLine("Виконала: Григорчук В.Ю., група П-42");
            Console.WriteLine("Варіант №8");
            Console.WriteLine("Завдання 4\n\n");

            Console.WriteLine("Введіть кількість рядків матриці: ");
            consoleRead = Console.ReadLine();

            while (!Int32.TryParse(consoleRead, out n))
            {
                Console.Write("Помилка. Введіть ціле число: ");

                consoleRead = Console.ReadLine();
            }

            Console.WriteLine("\nВведіть кількість стовпців матриці: ");
            consoleRead = Console.ReadLine();

            while (!Int32.TryParse(consoleRead, out m))
            {
                Console.Write("Помилка. Введіть ціле число: ");

                consoleRead = Console.ReadLine();
            }

            array = new double[n, m];

            result = new double[n];

            for (int value = 0; value < n; value++)
            {
                result[value] = 1;
            }

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * (33.110 - -33.531) + -33.531, 3);
                }
            }

            Console.WriteLine("\n\nМатриця " + n + "x" + m + ":");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(String.Format("{0,10}", array[i, j]));
                }

                Console.WriteLine();
            }

            for (int value = 0; value < n; value++)
            {
                for (int value2 = 0; value2 < m; value2++)
                {
                    result[value] += Math.Abs(array[value, value2]);
                }
            }

            Console.WriteLine("\n\n");

            for (int value = 0; value < result.Length; value++)
            {
                result[value] -= 1;
                Console.WriteLine("Сума модулів " + (value + 1) + " рядка: " + result[value]);
            }
            
            Array.Sort(result);

            Console.WriteLine("\nНайменша сума рядка матриці: " + result[0]);

            arraySortedRows = new double[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arraySortedRows[j] = Math.Abs(array[i, j]);
                }

                Array.Sort(arraySortedRows);

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = arraySortedRows[j];
                }
            }

            Console.WriteLine("\nМатриця " + n + "x" + m + " (модулі елементів рядка відсортовані за зростанням):");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(String.Format("{0,10}", array[i, j]));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
