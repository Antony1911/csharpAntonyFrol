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
            //54
            //SortArray();
            //56
            //SmallestRow();
            //58
            MultiplyMatrix();
        }

        static int[,] SetDoubleArray(int n, int m)      // create random array 
        {
            var random = new Random();
            int[,] array = new int[n, m];

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

        static void PrintArray(int[,] array)
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
            int[,] array = SetDoubleArray(n: 4, m: 7);
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
                        PrintArray(array: array);
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
            int[,] array = SetDoubleArray(n: 4, m: 7);
            //int[,] array = { { 17, 11, 18, 6, 9}, { 8, 4, 13, 21, 18 }, { 1, 21, 0, 13, 28 }, { 23, 23, 16, 6, 15 }, { 16, 25, 3, 15, 10 }, { 6, 4, 18, 7, 21 } };
            int[] sumArray = new int[array.GetLength(0)];

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
                Console.WriteLine($"sum of ({rows}): " + sum);
            }

            int maxElement = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (sumArray[i] > maxElement)
                {
                    maxElement = sumArray[i];
                }
            }
            Console.WriteLine($" --- Max sum of elements: {maxElement}");
        }



        //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        static void MultiplyMatrix()
        {
            //int[,] array01 = SetDoubleArray(4, 7);
            //int[,] array02 = SetDoubleArray(7, 4);

            int[,] array01 = { { 2, 0, -1 }, { 0, -2, 2 } };
            int[,] array02 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };


            int[,] resultMatrix = new int[array01.GetLength(0), array02.GetLength(0)];
            
            for (int i = 0; i < array01.GetLength(0); i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < array01.GetLength(1); j++)
                {

                    sum += array01[count, j] * array02[count, j];
                    count++;
                    Console.WriteLine(sum);

                }

            }
            
            PrintArray(resultMatrix);
        }


        //Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



    }
}
