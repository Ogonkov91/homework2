 int num;
 Console.Write("Введите трёхзначное число: ");
            num = Convert.ToInt32(Console.ReadLine());

            
            for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
            {
                Console.Write(ii + " Кажется это не трёхзначное число, попробуем ещё раз: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (num <= 100 | num > 999)
            {
                Console.WriteLine("Чтото пошло не так, программа прервана: ");
            }
            num = num / 10 % 10;
            Console.WriteLine($"Вторая цифра введённого числа: {num}");
