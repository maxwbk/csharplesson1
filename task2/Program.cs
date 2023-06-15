// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите первое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе число");
string input_string2 = Console.ReadLine();
Console.WriteLine("Напишите третье число");
string input_string3 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
int number3 = Convert.ToInt32(input_string3);
int max;

if (number1 < number2)
{
max = number2;

}
else
{
max = number1;
}

if (number3 > max)
{
max = number3;
}

Console.WriteLine($"Максимальное число {max}");
