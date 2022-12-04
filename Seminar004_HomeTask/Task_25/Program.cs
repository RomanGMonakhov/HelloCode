/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
НЕ ИСПОЛЬЗОВАТЬ Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.WriteLine("Enter the number A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number B: ");
int b = int.Parse(Console.ReadLine());

int rezult = 1;

for (int i = 1; i <= b; i++)
    rezult *= a;

Console.Write(rezult);