using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RandomTriple();
            //SumOddIndex();
            //MaxMinDifference();
        }

        //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        //Напишите программу, которая покажет количество чётных чисел в массиве.
        static void RandomTriple()
        {
            int count = 0;
            var random = new Random();
            int[] array = new int[random.Next(5, 13)];

            Console.WriteLine("Your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
                Console.Write(array[i] + " ");

                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count + $" <-- times");
        }


        //Задача 36: Задайте одномерный массив, заполненный случайными числами.
        //Найдите сумму элементов, стоящих на нечётных позициях.
        static void SumOddIndex()
        {
            int sumOddIndexValue = 0;
            var random = new Random();
            int[] array = new int[random.Next(4, 10)];

            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 101);
                Console.Write(array[i] + " ");

                if (i % 2 == 1)
                {
                    sumOddIndexValue += array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("sum of odd index: " + sumOddIndexValue);
        }


        //Задача 38: Задайте массив вещественных чисел.
        //Найдите разницу между максимальным и минимальным элементов массива.
        static void MaxMinDifference()
        {
            var random = new Random();
            double[] array = new double[random.Next(4, 10)];
            //double max, min;

            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"max({array.Max()}) - min({array.Min()}) = {array.Max() - array.Min()}");
        }


    }
}
