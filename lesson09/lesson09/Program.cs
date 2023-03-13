using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PrintNaturalDigits(2, 10));
            PrintNaturalDigits(10);


        }

        //Задача 64: Задайте значение N. Напишите программу, которая выведет все
        //натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
        static int PrintNaturalDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.Write(n + " ");
                return PrintNaturalDigits(n - 1);
            }
        }


        //Задача 66: Задайте значения M и N.
        //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
        //Даны два неотрицательных числа m и n.


    }
}
