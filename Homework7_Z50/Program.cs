/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Write("Введите количество строк массива:  ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива:  ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArrayMatrix(rows, columns, 10, 99);
PrintArray(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue=0, int maxValue=100)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите координаты:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

 if (a >= rows || b >= columns)
 Console.WriteLine("Tакого элемента нет");
 else
 {
    object c = array.GetValue(a,b);
    Console.WriteLine($"Значение элемента:{c}");
 }
