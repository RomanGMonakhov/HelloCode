/*
Задача 58:
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
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
    Console.WriteLine();
}

Console.Clear();

int[,] matrix_1 = new int[3, 4];
int[,] matrix_2 = new int[matrix_1.GetLength(0), matrix_1.GetLength(1)];

InputMatrix(matrix_1);
InputMatrix(matrix_2);

for (int i = 0; i < matrix_1.GetLength(0); i++)
{
    for (int k = 0; k < matrix_1.GetLength(1); k++)
        Console.Write($"{matrix_1[i, k] * matrix_2[i, k]} \t");
    Console.WriteLine();
}