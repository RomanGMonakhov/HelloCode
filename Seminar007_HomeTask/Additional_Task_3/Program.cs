/*
Заполнение диагоналями
*/

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write($"{matrix[i, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void InputMatrix(int[,] matrix)
{ 
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0, a = 0; j < m; j++, a++)
        {
            if (i == 0 & j == 0)
                matrix[i, j] = 0;
            else
            {
                if (j == 0)
                    matrix[i, j] = matrix[i - 1, j + 1] + 1;
                else
                {
                    if ((m - j <= i) & i > 0)
                    {
                        if (n > m)
                        {

                            if ((m - j + n - i - 1) >= m)

                                matrix[i, j] = matrix[i, j - 1] + m - 1;
                            else
                                matrix[i, j] = matrix[i, j - 1] + (m - j + n - i - 1);
                        }
                        else
                        {
                            matrix[i, j] = matrix[i, j - 1] + (m - j + n - i - 1);
                        }

                    }
                    else
                    {
                        if (j + i < n)
                            matrix[i, j] = matrix[i, j - 1] + j + i;
                        else
                            matrix[i, j] = matrix[i, j - 1] + n;
                    }
                }  
            }
        }
    }
}

Console.Clear();

int[,] matrix = new int[10, 15];

InputMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine();