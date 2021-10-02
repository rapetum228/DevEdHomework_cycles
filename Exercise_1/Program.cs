using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Возвести число A в степень B.");
            int A, B;
            Console.WriteLine("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i=0; i < B; i++)
            {
                result *= A; 
            }
            Console.WriteLine($"А в степени В: {result}");
        }
    }
}
