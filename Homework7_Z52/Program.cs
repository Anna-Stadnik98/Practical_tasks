/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

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

for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i =0; i < rows; i++)
    {
        sum = sum + array[i,j];        
    }
    double sr = Math.Round(sum / rows, 2);
    Console.WriteLine($"Среднее значение элементов в столбце {j+1}: {sr}");
}
