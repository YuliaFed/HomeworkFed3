// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N == 0) Console.Write("0");
if (N < 0) 
{
    N = N * -1;
}
if (N == 1) 
{
    Console.Write("1");
}
else Console.Write("1");
int i = 2;
while (i <= N)
{
    Console.Write(", " + i * i * i);
    i++;
}