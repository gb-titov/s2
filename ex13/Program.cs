using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

            Console.Write("Введите число: ");
            var num = Convert.ToInt32(Console.ReadLine());

            var thirdNum = GetThirdNum(num);

            if (thirdNum == -1)
                return;

            Console.WriteLine($"Третье число: {thirdNum}");
        }

        static int GetThirdNum(int num)
        {
            if (num < 0)
                num = -num;

            if(num < 100)
            {
                Console.WriteLine("Число не может быть меньше 100");
                return -1;
            }

            while (num > 1000)
            {
                num = num / 10;
            }

            return num % 10;
        }
    }
}
