// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");
