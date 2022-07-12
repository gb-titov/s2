using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            Console.Write("Введите номер дня недели: ");
            var weekDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsDayOff(weekDay));
        }

        static string IsDayOff(int day)
        {
            if (day < 1 || day > 7)
                return "День недели не существует";
            if (day > 0 && day < 6)
                return "Рабочий день";
            return "Выходной";
        }
    }
}
