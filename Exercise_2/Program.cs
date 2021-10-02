using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число (A). Вывести все числа");
            Console.WriteLine("от 1 до 1000, которые делятся на A");
            Console.WriteLine();
            int A, divided_by_A;
            Console.WriteLine("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=1000; i++)
            {
                if (i % A == 0)
                {
                    divided_by_A = i;
                    Console.WriteLine($"Число {divided_by_A} делится на {A} с результатом {i/A}");
                }
            }
        }
    }
}
