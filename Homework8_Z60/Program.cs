/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Write("Введите X:  ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите Y:  ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите Z:  ");
int z = int.Parse(Console.ReadLine());

int[,,] array3D = CreateArray(x, y, z, 10, 99);
PrintArray(array3D);
Console.WriteLine();

int[,,] CreateArray(int x, int y, int z, int minValue = 0, int maxValue = 100)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {            
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i}, {j}, {k})");                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }    
}