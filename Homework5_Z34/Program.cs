/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */


int[] array = new int [4];
var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 999);
}

Console.WriteLine($"[{String.Join(",", array)}]");

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if(array[j] % 2 == 0)
    {
        count++;
    }    
}
Console.WriteLine($"Количество чётных чисел в массиве:{count}");
