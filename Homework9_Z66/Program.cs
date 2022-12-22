/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите M:  ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N:  ");
int n = int.Parse(Console.ReadLine());

int SumRec (int m, int n)
{
    if (m <= n) return n + SumRec(m, n-1);
    else return 0;
}
Console.WriteLine(SumRec(m, n));