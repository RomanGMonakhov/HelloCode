/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов, запрашивает данные(элементы массива) у пользователя и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

Console.Clear();

int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++) {
    Console.WriteLine($"Entre item number {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", arr)}]");