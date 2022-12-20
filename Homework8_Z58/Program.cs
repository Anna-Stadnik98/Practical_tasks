/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Введите количество строк массива 1-й матрицы:  ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива 1-й матрицы и строк 2-й:  ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива 2-й матрицы:  ");
int c = int.Parse(Console.ReadLine());

int[,] array = FirstMartrix(a, b, 0, 10);
int[,] array2 = SecomdMartrix(b, c, 0, 10);
PrintArray(array);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();

int[,] ResultMatrix = new int[a,c];

MultiplyMatrix(array, array2, ResultMatrix);
PrintArray(ResultMatrix);

int[,] FirstMartrix(int a, int b, int minValue=0, int maxValue=100)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] SecomdMartrix(int b, int c, int minValue=0, int maxValue=100)
{
    int[,] result = new int[b, c];
    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < c; j++)
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

int[,] MultiplyMatrix(int[,] FirstMartrix, int[,] SecomdMartrix, int[,] ResultMatrix)
{
  for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstMartrix.GetLength(1); k++)
      {
        sum += FirstMartrix[i,k] * SecomdMartrix[k,j];
      }
      ResultMatrix[i,j] = sum;
    }
  }
  return ResultMatrix;
}
