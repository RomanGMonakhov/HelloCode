/*
Задача 50:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции в массиве нет
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = new Random().Next(0, 100);
            Console.Write($"{matrix[i, k]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] matrix = new int[10, 10];

InputMatrix(matrix);
Console.WriteLine();

Console.Write("Enter item position like 'm n': ");
int[] itemPosition = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).ToArray();

if (itemPosition[0] > matrix.GetLength(0) | itemPosition[1] > matrix.GetLength(1))
    Console.WriteLine("There is no such position in this matrix");
else
    Console.WriteLine($"Item [{itemPosition[0]}, {itemPosition[1]}] is: {matrix[itemPosition[0], itemPosition[1]]}");