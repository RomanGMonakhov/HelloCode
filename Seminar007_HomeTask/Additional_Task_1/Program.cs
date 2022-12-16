/*
Транспонирование

Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

Входные данные
Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
*/

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

StreamWriter writer = new StreamWriter(path_output, false);

int[,] TransposeMatrix(int[,] matrix)
{

    int temp = 0;

    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            temp = matrix[i, k];
            matrix[i, k] = matrix[matrix.GetLength(0) - i - 1, k];
            matrix[matrix.GetLength(0) - i - 1, k] = temp;

        }
    return matrix;
}

void OutputMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {    
        for (int k = 0; k < matrix.GetLength(1); k++)
            arr[k] = matrix[i, k];
        writer.WriteLine($"{string.Join(" ", arr)}");
    }
}

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

Console.Clear();

string[] lines = System.IO.File.ReadAllLines(path_input);

int[,] matrix = new int[lines.Length - 1, lines[1].Length / 2 + 1];

int[] arr = new int[matrix.GetLength(1)]; 

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        arr = lines[i + 1].Split(" ").Select(n => int.Parse(n)).ToArray();
        for (int k = 0; k < matrix.GetLength(1); k++)
            matrix[i, k] = arr[k];
    }

ShowMatrix(matrix);
TransposeMatrix(matrix);
ShowMatrix(matrix);
OutputMatrix(matrix);

writer.Close();