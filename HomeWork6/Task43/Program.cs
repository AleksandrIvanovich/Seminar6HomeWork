//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, 
//k2 = 9 -> (-0,5; -0,5)

double GetLength(string message)
{
    Console.WriteLine(message);
    var number = Convert.ToDouble(Console.ReadLine() ?? "");
    return number;
}

var b1 = GetLength("Введите b1 ");
var k1 = GetLength("Введите k1 ");
var b2 = GetLength("Введите b2 ");
var k2 = GetLength("Введите k2 ");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
//Console.WriteLine($"x={x}");
//Console.WriteLine($"y={y}");

Console.WriteLine($"Координаты точки пересечения двух прямых:({x};{y}).");
