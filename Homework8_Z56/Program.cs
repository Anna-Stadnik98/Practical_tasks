/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

Console.Write("Введите количество строк массива:  ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива:  ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSum(array)}");

int[,] GetArray(int rows, int columns, int minValue=0, int maxValue=100)
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
int MinSum (int[,] array)
{
    int minSum = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }        
        if (sum < minSum)
        {
           minSum = sum; 
           minRow = i + 1; 
        }        
    }
    return minRow;    
}