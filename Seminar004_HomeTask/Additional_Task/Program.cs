/*
Суперсдвиг

Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.
*/

int NShift(int n, int e, int k) {
    if (k < 0)
        k = k % 5 + 5;
    int rezult = (e + k) % n;
    return rezult;
}

Console.Clear();

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

string[] lines = System.IO.File.ReadAllLines(path_input);

int n = int.Parse(lines[0]);
int[] arr = lines[1].Split(' ').Select(p => int.Parse(p)).ToArray();
int k = int.Parse(lines[2]);

int[] arr_temp = new int[n];

for (int i = 0; i < n; i++)
    arr_temp[NShift(n, i, k)] = arr[i];

arr = arr_temp;

using (StreamWriter writer = new StreamWriter(path_output, false))
    await writer.WriteAsync(string.Join(", ", arr));