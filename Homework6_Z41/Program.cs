/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] arr = new int[5];

for(int i = 0; i<5; i++)
{
    Console.Write("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"Количество чисел больше 0 = {sum}");

