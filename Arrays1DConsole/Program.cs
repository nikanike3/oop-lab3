using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            string consoleRead;
            double result = 1;

            Console.WriteLine("Лабораторна робота №3");
            Console.WriteLine("Виконала: Григорчук В.Ю., група П-42");
            Console.WriteLine("Варіант №8");
            Console.WriteLine("Завдання 2\n\n");

            Console.WriteLine("Введіть кількість елементів масиву: ");
            consoleRead = Console.ReadLine();

            while (!Int32.TryParse(consoleRead, out n))
            {
                Console.Write("Помилка. Введіть ціле число: ");

                consoleRead = Console.ReadLine();
            }

            Console.WriteLine("\n Масив:");

            double[] array = new double [n];

            Random random = new Random();


            for (int value = 0; value < n; value++)
            {
                array[value] = Math.Round(random.NextDouble() * (12.951 - -28.305) + -28.305, 3);
                if(array[value] < 0)
                {
                    result *= array[value];
                }

                Console.Write(array[value] + " ");
            }

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine();

            Console.WriteLine("Введіть кількість перших елементів масиву для сортування (0-" + n +"): ");

            consoleRead = Console.ReadLine();

            while (!Int32.TryParse(consoleRead, out k))
            {
                Console.Write("Помилка. Введіть ціле число: ");

                consoleRead = Console.ReadLine();
            }

            if (k > n)
                k = n;
            else if (k < 0)
                k = 0;

            if (result == 0)
                result = 0.000;

            Console.WriteLine($"\n\n|{"Завдання - 1", -17}:{Math.Round(result, 3),25}|");
            
            for (int value = 0; value < k; value++)
            {
                Console.WriteLine($"|{"Завдання - 2", -17}:{value + " елемент масиву", 24}          ={array[value], 23}|");
            }

            Console.ReadKey();
        }
    }
}
