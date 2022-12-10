/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void CountEven(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            cnt++;
    Console.WriteLine($"Number of evens: {cnt}");
}

Console.Clear();

Console.WriteLine("Enter array lenght: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
CountEven(array);