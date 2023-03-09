using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            //MultiplyMatrix();
            //60
            ReturnTripleIndex(2, 2, 2);

        }

        static int[,] SetDoubleArray(int n, int m)      // random array 
        {
            var random = new Random();
            int[,] array = new int[n, m];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-5, 11);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");






            // Iterate the 2-dimensional array and display its values.
            //Console.WriteLine("Values of array elements:");
            //for (int outer = array.GetLowerBound(0); outer <= array.GetUpperBound(0); outer++)
            //    for (int inner = array.GetLowerBound(1); inner <= array.GetUpperBound(1); inner++)
            //        Console.WriteLine($"{'\u007b'}{outer}, {inner}{'\u007d'} = {array.GetValue(outer, inner)}");


            return array;
        }

        static int[,,] SetTripleArray(int n, int m, int k)
        {
            int[,,] array = new int[n, m, k];
            var result = Enumerable.Range(10,90).OrderBy(g => Guid.NewGuid()).ToArray();        // unique random values

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int v = 0; v < array.GetLength(2); v++)
                    {
                        array[i, j, v] = result[count];
                        count++;
                        Console.Write(array[i, j, v] + " ");
                    }
                    Console.WriteLine();
                }
            }
            return array;
        }


        static void PrintArray(int[,] array)        // pretty print array
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



        //Задача 54: Задайте двумерный массив.
        //Напишите программу, которая упорядочит по убыванию
        //элементы каждой строки двумерного массива.
        static void SortArray()
        {
            int[,] array = SetDoubleArray(n: 4, m: 7);
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
            int[,] array01 = SetDoubleArray(2, 3);
            int[,] array02 = SetDoubleArray(3, 3);
            int[,] resultMatrix = new int[array01.GetLength(0), array02.GetLength(0)];

            int multiSum;

            for (int i = 0; i < array01.GetLength(0); i++)
            {
                for (int j = 0; j < array01.GetLength(1); j++)
                {
                    multiSum = 0;
                    for (int k = 0; k < array01.GetLength(1); k++)
                    {
                        multiSum += array01[i, k] * array02[k, j];
                    }
                    resultMatrix[i, j] = multiSum;
                }
            }
            PrintArray(resultMatrix);
        }


        //Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
        //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        static void ReturnTripleIndex(int n, int m, int k)
        {
            int[,,] array = SetTripleArray(n, m, k);
            //int[,] array = SetDoubleArray(4, 4);
            //int[,,] array = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
            //                              { { 7, 8, 9 }, { 10, 11, 12 } } };

            for (int firstIndex = array.GetLowerBound(0); firstIndex <= array.GetUpperBound(0); firstIndex++)
            {
                for (int secondIndex = array.GetLowerBound(1); secondIndex <= array.GetUpperBound(1); secondIndex++)
                {
                    for (int thirdIndex = array.GetLowerBound(2); thirdIndex <= array.GetUpperBound(2); thirdIndex++)
                    {
                        Console.WriteLine($"3dIndex : {array.GetValue(firstIndex, secondIndex, thirdIndex)} ({firstIndex},{secondIndex},{thirdIndex})");
                    }
                }
            }
        }
    }
}
