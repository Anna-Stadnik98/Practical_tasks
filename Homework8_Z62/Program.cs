/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Write("Введите N:  ");
int n = int.Parse(Console.ReadLine());

int[,] SpiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
{
  SpiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
  {
    j++;
  }    
  else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
  {
    i++;
  }    
  else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
  {
    j--;
  }    
  else
  {
    i--;
  }    
}
PrintArray(SpiralMatrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}