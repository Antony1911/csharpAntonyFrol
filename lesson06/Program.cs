using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DigitsAboveZero();
            GetPointCoords(k1: 5, b1: 2, k2: 9, b2: 4);


        }
        //Задача 41: Пользователь вводит с клавиатуры M чисел.
        //Посчитайте, сколько чисел больше 0 ввёл пользователь.
        static void DigitsAboveZero()
        {
            var random = new Random();
            int[] array = new int[random.Next(4, 8)];
            int countAboveZero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int userInput;
                
                Console.WriteLine($"Enter a digit ({i+1} of {array.Length}): ");
                userInput = Convert.ToInt32(Console.ReadLine());
                array[i] = userInput;

                if (array[i] > 0)
                {
                    countAboveZero++;
                }
            }
            Console.WriteLine(countAboveZero + " digits are above zero");
        }

        //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
        //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        static void GetPointCoords(float k1, float b1, float k2, float b2)
        {
            if (k1 == k2)
            {
                Console.WriteLine("Lines are parallel");
            }
            else if (k1 == k2 || b1 == b2)
            {
                Console.WriteLine("Lines are coinsided");
            }
            else
            {
                float x, y;

                x = (b2 - b1) / (k1 - k2);
                y = k2 * x + b2;

                Console.WriteLine($"Coords: ({x}, {y})");
            }
        }




    }
}
