/*
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

int Akk(int a, int b)
{
    int res = 0;
    if (a == 0) res = b + 1;
    else if (b == 0) res = Akk(a - 1, 1);
    else if (a * b != 0) res = Akk(a - 1, Akk(a, b - 1));
    return res; 
}

Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum from M to N is: {Akk(M, N)}");