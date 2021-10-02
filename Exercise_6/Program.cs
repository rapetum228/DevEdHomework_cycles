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
            int first_prev = 1;
            int second_prev = 1;
            int FibonacciNumber = 0;

            while (FibonacciNumber < N - first_prev)
            {
                FibonacciNumber = first_prev + second_prev;
                first_prev = second_prev;
                second_prev = FibonacciNumber;
            }
            Console.WriteLine($"\nЧисло Фибоначчи до N = {N} это {FibonacciNumber}");

        }
    }
}
