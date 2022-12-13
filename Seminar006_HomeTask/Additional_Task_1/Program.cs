/*
Дана строка, состоящая из N попарно различных символов.
Требуется вывести все перестановки символов данной строки.

Входные данные
Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

Выходные данные
В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке.
Перестановки можно выводить в любом порядке.
Повторений и строк, не являющихся перестановками исходной, быть не должно.
*/

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

StreamWriter writer = new StreamWriter(path_output, false);

void Swap(char[] arr, int i, int k)
{
    char temp = arr[i];
    arr[i] = arr[k];
    arr[k] = temp;
}

void Permutations(char[] arr, int curr_idx = 0)
{
    if (curr_idx == arr.Length - 1)
    {
        writer.WriteLine($"{string.Join("", arr)}");
    }

    for (int i = curr_idx; i < arr.Length; i++)
    {
        Swap(arr, curr_idx, i);
        Permutations(arr, curr_idx + 1);
        Swap(arr, curr_idx, i);
    }   
}

Console.Clear();

string[] lines = System.IO.File.ReadAllLines(path_input);
Permutations(lines[0].ToArray());

writer.Close();