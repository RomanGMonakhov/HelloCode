/*
Задача 66:
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int SumMN(int a, int b)
{
    int res = b;
    if (a != b) res = res + SumMN(a, b - 1);
    return res;
}

Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum from M to N is: {SumMN(M, N)}");