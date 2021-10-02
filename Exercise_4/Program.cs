using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Вывести наибольший делитель (кроме самого A) числа A" + "\n");
            int A;
            Console.WriteLine("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            int divider_A = 0;

            for (int i=1; i < A; i++)
            {
                if (A % i == 0 && A != i)
                    divider_A = i;
            }
            
            Console.WriteLine($"Наибольший делитель {A} число {divider_A}");
        }
    }
}
