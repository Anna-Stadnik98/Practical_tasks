/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите m:  ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n:  ");
int n = int.Parse(Console.ReadLine());
A(m,n);

static int A(int m, int n)
 {
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m,n);
}
Console.WriteLine($"A(m,n) = {A(m,n)}");