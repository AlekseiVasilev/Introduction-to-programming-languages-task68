// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("\t Задача №68");
Console.WriteLine("Введите число M:");
int m = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.WriteLine("Введите число N:");
int n = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));

Console.WriteLine($"A(m,n) = {AckermanFunction(m, n)}");

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
