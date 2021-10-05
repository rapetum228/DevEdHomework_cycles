using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число (N). " +
                "Выведите N-ое число ряда фибоначчи. " +
                "В ряду фибоначчи каждое следующее число является суммой двух предыдущих. " +
                "Первое и второе считаются равными 1. \n");
            // 1 1 2 3 5 8 13 21 34 55 89 144 ...
            int N;
            Console.WriteLine("Введите число N: ");
            N = Convert.ToInt32(Console.ReadLine());
            int firstPrev = 1;
            int secondPrev = 1;
            int fibonacciNumber = 0;

            while (fibonacciNumber < N - firstPrev)
            {
                fibonacciNumber = firstPrev + secondPrev;
                firstPrev = secondPrev;
                secondPrev = fibonacciNumber;
            }
            Console.WriteLine($"\nЧисло Фибоначчи до N = {N} это {fibonacciNumber}");

        }
    }
}
