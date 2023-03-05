using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SetArray();
            //GetElement(3, 2);
            AvSum();
        }

        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        static int[,] SetArray()
        {
            int m, n;
            Console.WriteLine("Insert rows: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert colomns: ");
            n = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[,] array = new int[m, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return array;
        }


        //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        //и возвращает значение этого элемента или же указание, что такого элемента нет.
        static void GetElement(int x, int y)
        {
            int[,] array = SetArray();

            try
            {
                Console.WriteLine($"position for ({x}, {y}): " + array[x, y]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"There is no element on position ({x}, {y})");
            }


        }


        //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        static void AvSum()
        {
            int[,] array = SetArray();
            int n = 0;
            float sum = 0;
            int count = 0;

            Console.WriteLine();
            while (n < array.GetLength(0))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine(array[i, n]);
                    sum = sum + array[i, n];
                    count++;
                }
                Console.WriteLine("sum: " + sum);
                Console.WriteLine($"Avarege: {sum/count}");

                sum -= sum;
                count -= count;

                Console.WriteLine();
                n++;
            }
        }
    }
}
