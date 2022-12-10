/*
Гипотеза Гольдбаха

Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа.
Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

Входные данные
Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N.
Первым выводится наименьшее число.
*/

Boolean IsPrime(int n)
{
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    
    int i = 3;
    while (i * i <= n)
    {
        if (n % i == 0)
            return false;
        i = i + 2;
    }
    return true; 
}

String SumPrimes(int n)
{
    for (int i = 2; i <= n / 2; i++)
        if (IsPrime(i) && IsPrime(n - i))
            return $"{i} {n - i}";
    return "Error";
}

Console.Clear();

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

string[] lines = System.IO.File.ReadAllLines(path_input);

int n = int.Parse(lines[0]);

using (StreamWriter writer = new StreamWriter(path_output, false))
    await writer.WriteAsync(SumPrimes(n));