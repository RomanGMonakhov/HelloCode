/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, k]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] matrix = new int[10, 6];

InputMatrix(matrix);
Console.WriteLine();

int rowSum = 0;
int minSumRow = 0;

for (int k = 0; k < matrix.GetLength(1); k++)
    rowSum += matrix[k, 0];

for (int i = 1; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
        sum += matrix[i, k];
    if (sum < rowSum)
    {
        rowSum = sum;
        minSumRow = i;
    }
}

Console.Write($"{minSumRow + 1} row");