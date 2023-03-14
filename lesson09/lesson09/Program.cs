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
            //64
            //PrintNaturalDigits(13);

            //66
            //Console.WriteLine(SumOfSection(9, 10));

            //68
            Console.WriteLine(AckermanFunction(4, 1));


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
        static int SumOfSection(int m, int n)
        {
            if (n == m)
            {
                return n;
            }
            return n + SumOfSection(m, n - 1);
        }


        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
        //Даны два неотрицательных числа m и n.
        static int AckermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else
            {
                if ((m != 0) && (n == 0))
                {
                    return AckermanFunction(m - 1, 1);
                }
                else
                {
                    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
                }
            }
        }
    }
}
