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
            int dividerA = 0;

            for (int i=A-1; i > 0; i--)
            {
                if (A % i == 0 && A != i)
                {
                    dividerA = i;
                    break;
                }
            }
            
            Console.WriteLine($"Наибольший делитель {A} число {dividerA}");
        }
    }
}
