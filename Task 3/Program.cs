// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

int f(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return f(m - 1, 1);
    else
        return f(m - 1, f(m, n - 1));
}

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));
