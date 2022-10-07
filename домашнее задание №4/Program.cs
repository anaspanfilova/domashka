// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine()!);
int max = x;
if (y > x)
    max = y;
else 
{
    max = x;
}
    if (z > max)
        max = z;
Console.WriteLine($"{max}");