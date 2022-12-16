/*
Задача 47:

Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = Math.Round(new Random().NextDouble() * (100 - 0) + 0, 2);
            Console.Write($"{matrix[i, k]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Enter matrix size [m, n] like 'm n': ");
int[] matrixSize = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).ToArray();

double[,] matrix = new double[matrixSize[0], matrixSize[1]];

InputMatrix(matrix);