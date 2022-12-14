/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76 */


double[] array = new double [4];
var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(0, 100));
}

Console.WriteLine($"[{String.Join(",", array)}]");

double min = array[0];
double max = array[0];

for (int j = 1; j < array.Length; j++)
{
    if(array[j] > max)
    {
        max = array[j];
    }
    if(array[j] < min)
    {
        min = array[j];
    }            
}
Console.WriteLine($"Максимальное значение в массиве ={max}, минимальное ={min}");
double result = max - min;
Console.WriteLine($"Разница между max и min элементами массива:{result}");
