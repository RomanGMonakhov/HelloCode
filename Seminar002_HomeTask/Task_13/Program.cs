/*
Задача 13:
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
(НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)
*/

Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine());

if (n < 100)
    Console.WriteLine("третьей цифры нет");
else {
    while (n > 999)
        n = n / 10;
    Console.WriteLine($"The third digit is : {n % 10}");
}