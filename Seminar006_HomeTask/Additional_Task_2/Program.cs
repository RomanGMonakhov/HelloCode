/*
Площадь треугольника

По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Входные данные
Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.
*/

double TriangleArea(double x1, double y1, double x2, double y2, double x3,  double y3)
{
   return (0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)));
}

Console.Clear();

string path_input = Directory.GetCurrentDirectory() + "\\INPUT.txt";
string path_output = Directory.GetCurrentDirectory() + "\\OUTPUT.txt";

string[] lines = System.IO.File.ReadAllLines(path_input);
double[] arr = lines[0].Split(" ").Select(p => double.Parse(p)).ToArray();

StreamWriter writer = new StreamWriter(path_output, false);
writer.WriteLine(TriangleArea(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
writer.Close();