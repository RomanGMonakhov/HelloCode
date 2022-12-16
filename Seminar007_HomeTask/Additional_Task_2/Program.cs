/*
Миша и негатив

Миша уже научился хорошо фотографировать и недавно увлекся программированием.
Первая программа, которую он написал, позволяет формировать негатив бинарного черно-белого изображения.

Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых может быть либо черным, либо белым.
Негатив такого изображения получается путем замены каждого черного пикселя на белый, а каждого белого пикселя – на черный.

Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее исполнения мог получаться некорректный негатив.
Для того чтобы оценить уровень несоответствия получаемого негатива исходному изображению, Миша начал тестировать свою программу.

В качестве входных данных он использовал исходные изображения.
Сформированные программой негативы он начал тщательно анализировать, каждый раз определяя число пикселей негатива, которые получены с ошибкой.

Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое изображение и полученный Мишиной программой негатив,
и на основе этого определяет количество пикселей, в которых допущена ошибка.

Входные данные
Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину исходного изображения (в пикселях).
Последующие n строк содержат описание исходного изображения.
Каждая строка состоит из m символов «B» и «W». Символ «B» соответствует черному пикселю, а символ «W» – белому.
Далее следует пустая строка, а после нее – описание выведенного Мишиной программой изображения в том же формате, что и исходное изображение.

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.
*/

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

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

StreamWriter writer = new StreamWriter(path_output, false);

string[] lines = System.IO.File.ReadAllLines(path_input);

int[] matrixSize = lines[0].Split(" ").Select(n => int.Parse(n)).ToArray();

int[,] matrix_positive = new int[matrixSize[0], matrixSize[1]];
int[,] matrix_negative = new int[matrixSize[0], matrixSize[1]];
char[] arr = new char[matrix_positive.GetLength(1)];

for (int i = 0; i < matrix_positive.GetLength(0); i++)
    {
        arr = lines[i + 1].ToCharArray();
        for (int k = 0; k < arr.Length; k++)
            matrix_positive[i, k] = arr[k];
    }

for (int i = 0; i < matrix_positive.GetLength(0); i++)
    {
        arr = lines[i + matrix_positive.GetLength(0) + 2].ToCharArray();
        for (int k = 0; k < arr.Length; k++)
            matrix_negative[i, k] = arr[k];
    }

Console.Clear();

ShowMatrix(matrix_positive);
ShowMatrix(matrix_negative);

int sum = 0;

for (int i = 0; i < matrix_positive.GetLength(0); i++)
    for (int k = 1; k < matrix_positive.GetLength(1); k++)
        {
            if (matrix_positive[i, k] == matrix_negative[i, k])
                sum += 1;
        }

writer.WriteLine(sum);
writer.Close();