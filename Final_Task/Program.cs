/*
Задача:
Из имеющегося массива строк сфоримировать массив строк,
длина который меньше либо равно 3.
*/

Console.Clear();

Console.WriteLine("Enter number of strings in array: ");
int strings_count = int.Parse(Console.ReadLine());

string[] array = new string[strings_count];

void FillArray(ref string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Console.ReadLine();
}

void ShrinkArray(ref string[] array)
{
    array = array.Where(val => val.Length <= 3).ToArray();
}

FillArray(ref array);
ShrinkArray(ref array);

for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);