using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace someGet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GradeIt(2, 3);
            //ReturnSum(1245678);
            //ArrayIt();

        }

        //Задача 25: Напишите метод, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
        static void GradeIt(int a, int b)
        {
            int grade;
            grade = a;

            while (b > 1)
            {
                grade *= a;
                b--;
            }
            Console.WriteLine(grade); ;
        }


        //Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
        static void ReturnSum(int number)
        {
            int sumOfDigits = 0;
            int iter = 0;
            while (number != 0)
            {
                iter = number % 10;
                sumOfDigits += iter;
                number = (number - iter) / 10;
            }
            Console.WriteLine(sumOfDigits);
        }


        //Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.

        static void ArrayIt()
        {
            int arrayUserLength;
            Console.WriteLine("Print Lenght of the array: ");
            arrayUserLength = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] array = new int[arrayUserLength];

            Console.WriteLine($"Your random array of {arrayUserLength} elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(random.Next(0, 15), random.Next(16, 30));
                Console.Write(array[i] + " ");
            }
            
        }
    
    }
}
