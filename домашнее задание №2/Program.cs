// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
int max = x;
if (x > max)
{
Console.WriteLine($"{x} = max");
}
else
{
   Console.WriteLine($"{y} = max"); 
}