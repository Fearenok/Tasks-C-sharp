﻿Console.Write("Введи начальное число M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи начальное число N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
if (M > N)
   for (int i = N; i <= M; i++)
      Console.Write($" {i}");
else
   for (int i = M; i <= N; i++)
      Console.Write($" {i}");