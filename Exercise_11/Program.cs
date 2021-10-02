using System;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N). " +
                "Выведите числа в диапазоне от 1 до N, сумма четных цифр которых " +
                "больше суммы нечетных. \n");
            Console.WriteLine("Введите число");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            Console.WriteLine("");
            
            for (int i = 1; i <= userNum; i++)
            {
                int counterEven = 0;
                int counterOdd = 0;
                int iCopy = i;
                while (iCopy != 0)
                {
                    remainder = iCopy % 10;
                    iCopy /= 10;
                    if (remainder % 2 == 1)
                        counterOdd+=remainder;
                    else counterEven += remainder;
                }
                if (counterEven > counterOdd)
                    Console.WriteLine($"Число {i}. Cумма чётных - {counterEven}" +
                        $", сумма нечётных - {counterOdd}");
            }
        }
    }
}
