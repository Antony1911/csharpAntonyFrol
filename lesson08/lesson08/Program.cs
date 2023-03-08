using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SetDoubleArray();
            //SortArray();
            SmallestRow();
        }

        static int[,] SetDoubleArray()
        {
            var random = new Random();
            int[,] array = new int[random.Next(4, 7), random.Next(4, 7)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 30);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
            return array;
        }

        //Задача 54: Задайте двумерный массив.
        //Напишите программу, которая упорядочит по убыванию
        //элементы каждой строки двумерного массива.

        static void ReturnArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SortArray()
        {
            int[,] array = SetDoubleArray();

            //test array
            // ---------------------------------------------------------------
            //int[,] array = { { 21, 28, 16, 2, 0, 19 }, { 22, 3, 7, 26, 20, 28 }, { 16, 3, 15, 26, 27, 1 }, { 15, 17, 16, 10, 9, 13 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }   
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");

            int rowsLenght = array.GetLength(0);
            int colomnsLenght = array.GetLength(1);

            for (int rows = 0; rows < rowsLenght; rows++)
            {
                for (int colomns = 0; colomns < colomnsLenght; colomns++)
                {
                    for (int x = 0; x < colomnsLenght - colomns - 1; x++)
                    {
                        if (array[rows, x] < array[rows, x + 1])
                        {
                            int temp = array[rows, x];
                            array[rows, x] = array[rows, x + 1];
                            array[rows, x + 1] = temp;
                        }
                        Console.WriteLine($"x = {x}; row = {rows}; col = {colomns}");
                        ReturnArray(array: array);
                    }
                }
            }

            for (int i = 0; i < rowsLenght; i++)
            {
                for (int j = 0; j < colomnsLenght; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Задача 56: Задайте прямоугольный двумерный массив.
        //Напишите программу, которая будет находить строку c наименьшей суммой элементов.
        static void SmallestRow()
        {
            //int[,] array = SetDoubleArray();
            int[,] array = { { 17, 11, 18, 6, 9}, { 8, 4, 13, 21, 18 }, { 1, 21, 0, 13, 28 }, { 23, 23, 16, 6, 15 }, { 16, 25, 3, 15, 10 }, { 6, 4, 18, 7, 21 } };
            int[] sumArray = new int[array.GetLength(0)];

            Console.WriteLine(sumArray.Length + " === ");

            ReturnArray(array);

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                int sum = 0;
                int count = 0;

                for (int colomns = 0; colomns < array.GetLength(1); colomns++)
                {
                    sum += array[rows, colomns];
                    count++;
                }

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[rows] = sum;
                }
                Console.WriteLine();
                Console.WriteLine(sum);
            }

            int maxElement = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (sumArray[i] > maxElement)
                {
                    maxElement = sumArray[i];
                }
            }
            Console.WriteLine($"Max sum of elements: {maxElement}");
        }



        //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



        //Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



    }
}
