using System;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 2 числа. Сообщите, есть ли " +
                "в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, " +
                "ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ” \n");

            int userNum1, userNum2;
            Console.WriteLine("Введите первое число");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            userNum2 = Convert.ToInt32(Console.ReadLine());

            bool flag = true;
            int remainder1, remainder2;
            while (flag && userNum1 != 0)
            {
                int copyUserNum2 = userNum2;
                remainder1 = userNum1 % 10;
                userNum1 /= 10;
                while (flag && copyUserNum2 != 0)
                {
                    remainder2 = copyUserNum2 % 10;
                    copyUserNum2 /= 10;
                    if (remainder1 == remainder2) 
                        flag = !flag;
                }
            }

            if (flag)
                Console.WriteLine("\nНЕТ");
            else
                Console.WriteLine("\nДА");
            
        }
    }
}
