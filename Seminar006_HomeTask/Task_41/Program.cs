/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int PositiveCount(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > 0) cnt += 1;
    return cnt;
}

Console.Clear();

Console.WriteLine("Enter some numbers using ', ' as separator: ");
string str = Console.ReadLine();

int[] arr = str.Split(", ").Select(n => int.Parse(n)).ToArray();

Console.Write(PositiveCount(arr));