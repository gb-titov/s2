using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            Console.Write("Введите трехзначное число: ");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: " + GetSecondNumber(num));
        }


        static int GetSecondNumber(int num)
        {
            if (num < 0)
                num = -num;

            if (num < 99 || num > 1000)
                return -1;

            num = num / 10;

            return num % 10 ;
        }
    }
}
