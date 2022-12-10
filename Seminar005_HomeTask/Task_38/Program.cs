/*
Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * (100 - 0) + 0;
}

void MinMaxDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"Differnce betwee min and max items: {max - min}");
}

Console.Clear();

Console.WriteLine("Enter array lenght: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];

InputArray(array);
Console.Write($"[{string.Join("; ", array)}]");
Console.WriteLine();
MinMaxDiff(array);