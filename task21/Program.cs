// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Вводим координаты первой точки:");
Console.Write("Введите координату X: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вводим координаты второй точки:");
Console.Write("Введите координату X: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z: ");
int Z2 = int.Parse(Console.ReadLine()!);

double X = Math.Pow(X2 - X1, 2);
double Y = Math.Pow(Y2 - Y1, 2);
double Z = Math.Pow(Z2 - Z1, 2);
Double A = X + Y + Z;
double distance = Math.Round(Math.Sqrt(A), 2);
Console.WriteLine("Расстояние между точками: " + distance);