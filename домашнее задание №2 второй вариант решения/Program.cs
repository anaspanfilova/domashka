// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
if (x > y)
{
Console.WriteLine($"{x} наибольшее, а {y} наименьшее");
}
else
{
   Console.WriteLine($"{y} наибольшее, а {x} наименьшее"); 
}