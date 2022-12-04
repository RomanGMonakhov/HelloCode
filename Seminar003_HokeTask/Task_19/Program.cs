/*
Задача 19:
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.Write("Enter the five-digit number: ");
int n = int.Parse(Console.ReadLine());

Console.Write((n / 10000 % 10) == (n % 10) &&  (n / 1000 % 10) == (n / 10 % 10));