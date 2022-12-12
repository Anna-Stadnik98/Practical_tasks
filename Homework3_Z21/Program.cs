// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X1: ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1: ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2: ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2: ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2: ");
int Zb = int.Parse(Console.ReadLine());

double AC = (Xb - Xa);
double BC = (Yb - Ya);
double DC = (Zb - Za);

double AB = Math.Pow(AC, 2) + Math.Pow(BC, 2) + Math.Pow(DC, 2);

double result = Math.Sqrt(AB);

Console.WriteLine($"Расстояние между точками в пространстве равно {result}");
