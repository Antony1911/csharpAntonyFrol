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
            RandomTriple();
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
    }
}
