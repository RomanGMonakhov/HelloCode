/*
Задача 27:
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.WriteLine("Enter the number: ");
string s = Console.ReadLine();

int rezult = 0;

for (int i = 0; i < s.Length; i++)
    rezult += int.Parse(s[i].ToString());

Console.Write(rezult);