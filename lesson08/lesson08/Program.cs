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
            SortArray();
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
        static void SortArray()
        {
            int[,] array = SetDoubleArray();
            int colomnLenght = array.GetLength(0);
            int rowLenght = array.GetLength(1);

            for (int colomn = 0; colomn < colomnLenght; colomn++)
            {
                for (int row = 0; row < rowLenght; row++)
                {
                    for (int x = 0; x < rowLenght - row - 1; x++)
                    {
                        if (array[colomn, x] < array[colomn, x + 1])
                        {
                            int temp = array[colomn, x];
                            array[colomn, x] = array[colomn, x + 1];
                            array[colomn, x + 1] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < colomnLenght; i++)
            {
                for (int j = 0; j < rowLenght; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Задача 56: Задайте прямоугольный двумерный массив.
        //Напишите программу, которая будет находить строку наименьшей суммой элементов.




        //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



        //Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    

    
    }
}
