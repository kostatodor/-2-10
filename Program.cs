﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int ii = 1; ii < 3 && (a <= 100 | a > 999); ii++)
            {
                Console.Write(ii + " Кажется это не трёхзначное число, попробуем ещё раз: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (a <= 100 | a > 999)
            {
                Console.WriteLine("Чтото пошло не так, программа прервана: ");
            }

            a = a / 10 % 10;
            Console.WriteLine($"Вторая цифра введённого числа: {a}");