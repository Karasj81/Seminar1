// 1 Задача

Console.Write("Введите число A:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B:");
int number2 = int.Parse(Console.ReadLine()!);
if (number1>number2)
{
    Console.WriteLine("A больше B");
}
else
{
    if (number1<number2)
    {
        Console.WriteLine("B больше A");
    }
    else
    {
        Console.WriteLine("A равно B");
    }
}

// 2 Задача

Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (max<number2)
{
    max = number2;
}
if (max<number3)
{
    max = number3;
}
Console.Write($"Максимальое число = {max}");

// 3 Задача

Console.Write("Введите число:");
int number1 = int.Parse(Console.ReadLine()!);
if (number%2 ==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}

// 4 Задача

Console.Write("Введите N:");
int N = int.Parse(Console.ReadLine():);
int i = 1;
while (1 <= N)
{
    if (i%2 ==0)
    {
        Console.WriteLine($"{i}");
    }
    i++;
}
