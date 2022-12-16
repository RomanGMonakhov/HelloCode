/*
Задача 52:

Задайте двумерный массив из целых чисел
Найдите среднее арифметическое элементов в каждом столбце

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int[,] matrix = new int[10, 6];

InputMatrix(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double avg = 0;
        for (int k = 0; k < matrix.GetLength(0); k++)
            avg += matrix[k, i];
    avg = Math.Round(avg / matrix.GetLength(0), 2);
    Console.Write($"{avg} \t");
}