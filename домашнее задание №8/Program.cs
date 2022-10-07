// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");
int X = int.Parse(Console.ReadLine()!);
int N2 = 2;
while(N2 <= X)
{
    Console.Write($"{N2} ");
    N2 = N2 + 2;
}