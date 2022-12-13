// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = new int[8];

for(int i = 0; i<8; i++)
{
    Console.Write("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("[");
System.Console.Write(string.Join(",", arr));
System.Console.Write("]");
