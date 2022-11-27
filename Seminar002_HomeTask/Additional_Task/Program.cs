/*
Задана последовательность натуральных чисел, завершающаяся числом 0.
Требуется определить значение второго по величине элемента в этой последовательности,
то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100.
Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.
*/

Console.Clear();

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

int[] arr = System.IO.File.ReadAllText(path_input).Split(' ').Select(n => int.Parse(n)).ToArray();

int i = 0;
int n_1st = 0;
int n_2nd = 0;

while (arr[i] != 0) {
    if (arr[i] >= n_1st) {
        n_2nd = n_1st;
        n_1st = arr[i];
    }
    else if (arr[i] > n_2nd)
        n_2nd = arr[i];
    i++;
}

using (StreamWriter writer = new StreamWriter(path_output, false))
    await writer.WriteAsync(n_2nd.ToString());