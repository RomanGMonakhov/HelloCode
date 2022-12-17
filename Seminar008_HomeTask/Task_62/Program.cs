/*
Задача 62
Напишите программу, которая заполнит спирально массив 4 на 4
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

string direction = "E";

void Turn(ref string direction)
{
    if (direction == "N") direction = "E";
    else if (direction == "E") direction = "S";
    else if (direction == "S") direction = "W";
    else direction = "N";
}

void Step(ref int i, ref int k)
{ 
    if (direction == "N") i--;
    else if (direction == "E") k++;
    else if (direction == "S") i++;
    else  k--;
}

void StepBack(ref int i, ref int k)
{ 
    if (direction == "N") i++;
    else if (direction == "E") k--;
    else if (direction == "S") i--;
    else k++;
}

void InputMatrix(int?[,] matrix)
{
    int i = 0;
    int k = 0;

    for (int j = 0; j < matrix.GetLength(0) * matrix.GetLength(1); j++)
    {
        if (i == matrix.GetLength(0) || k == matrix.GetLength(1) || i < 0 || k < 0 || matrix[i, k].HasValue)
        {
            StepBack(ref i, ref k); 
            Turn(ref direction);
            Step(ref i, ref k);
            matrix[i, k] = j;
            Step(ref i, ref k);
        }
        else
        {
            matrix[i, k] = j;
            Step(ref i, ref k);
        }
    }
}

void ShowMatrix(int?[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write($"{matrix[i, k]} \t");
    Console.WriteLine();
    }
}

Console.Clear();

int?[,] matrix = new int?[4, 4];

InputMatrix(matrix);
ShowMatrix(matrix);