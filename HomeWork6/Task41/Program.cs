//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int GetLength()
{
    Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int a = GetLength();
int b = GetLength();
int c = GetLength();
int d = GetLength();
int f = GetLength();
int g = GetLength();

int count = 0;
//void FindingPositiveNumbers(int a, int b, int c, int d, int f, int g)
//{
    if (a > 0)
    count = count + 1;
    if (b > 0)
    count = count + 1;
    if (c > 0)
    count = count + 1;  
    if (d > 0)
    count = count + 1;
    if (f > 0)
    count = count + 1;
    if (g > 0)
    count = count + 1; 

Console.WriteLine($"Количество положительных чисел равно: {count}");



