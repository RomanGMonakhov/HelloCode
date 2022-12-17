/*
Треугольник Паскаля

Вывести первые N строк треугольник Паскаля
Сделать вывод в виде равнобедренного треугольника.

Ввод: 5
Вывод
1
11
121
1331
14641
*/

int N = 5;
int[,] triangle = new int[N, N];
const int cellWight = 2;

void FillTriangle()
{
    for (int i = 0; i < N; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < N; i++)
    {
        for (int k = 1; k <= i; k++)
        {
            triangle[i, k] = triangle[i - 1, k - 1] + triangle[i - 1, k];
        }
    }
}

void ShowTriangle()
{
    int col = cellWight * N;
    for (int i = 0; i < N; i++)
    {
        for (int k = 0; k < N; k++)
        {
            Console.SetCursorPosition(col, i + 1);   
            if (triangle[i, k] != 0) Console.Write($"{triangle[i, k], cellWight} ");
            col += cellWight * 2;
        }
        col = cellWight * N - cellWight * (i + 1);
        Console.WriteLine();
    }
}

Console.Clear();

FillTriangle();
ShowTriangle();