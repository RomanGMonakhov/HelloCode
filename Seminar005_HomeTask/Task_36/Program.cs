/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
            sum += array[i];
    Console.WriteLine($"Sum of odds: {sum}");
}

Console.Clear();

Console.WriteLine("Enter array lenght: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
SumOdd(array);