﻿// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите любое число");
string input_string1 = Console.ReadLine();
int number = Convert.ToInt32(input_string1);
if (number % 2 == 0)
        {
            Console.WriteLine($"{number} является четным числом.");
        }
        else
        {
            Console.WriteLine($"{number} не является четным числом.");
        }

        Console.ReadLine();