using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит целое положительное число, " +
                "которое является кубом целого числа N. " +
                "Найдите число N методом половинного деления.\n");
            Console.WriteLine("Пожалуйста, введите число, являющееся кубом какого-то целого числа:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            double start, end, middle=0;
            start = 0;
            end = 1.0 * userNum;

            while (Math.Abs(middle * middle * middle - userNum) > 0.00001) {
                middle = start + (end - start) / 2;

                if (middle * middle * middle > userNum) 
                {

                    end = middle;
                }
                else
                {
                    start = middle;
                }

            }
            Console.WriteLine(Math.Round(middle));
        }
    }
}
