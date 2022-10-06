//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int GetLength()
{
Console.WriteLine("Введите чило от -1000 до 1000");
int numbers = int.Parse(Console.ReadLine()?? "");
return numbers;
}

//int [] arr = new int[numbers];
int coint = 0;
//int NegativeNumbers()
//{
   for (int i = 0; i < arr.Length; i++)
   {
     if (arr[i] < 0)
     {
        coint++;
     }
   }

    return coint;
  

Console.WriteLine(coint);