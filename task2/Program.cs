﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
           int num, count, numDigit; 

            Console.Write("Введите любое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            numDigit = NumberDigit(num);// Пробуем функцию/метод. (прим вероятно подошло бы и для для проверки первой задачи)

           int NumberDigit(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}         

            if (numDigit <= 2)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                if (numDigit > 3)
                {
                    num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3)); // немного Math
                }
                num = num % 10;
                Console.WriteLine($"Третья цифра введённого числа: {num}");
            }
    