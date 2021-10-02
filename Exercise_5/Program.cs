using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). " +
                "Вывести сумму всех чисел из диапазона от A до B, " +
                "которые делятся без остатка на 7. " +
                "(Учтите, что при вводе B может оказаться меньше A)" + "\n");
            int A, B, start_range, end_range;
            int counter = 0;
            Console.WriteLine("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                start_range = A;
                end_range = B;
            }
            else
            {
                start_range = B;
                end_range = A;
            }

            for (int i = start_range; i <= end_range; i++)
            {
                if (i % 7 == 0)
                    counter += i;
            }
            Console.WriteLine($"\nСумма чисел делящихся на 7 " +
                $"от {start_range} до {end_range} равна {counter}");
            


        }
    }
}
