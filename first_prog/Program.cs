﻿
Console.WriteLine("Введите любое число");
int chislo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите другое число для вычислений");
int prost = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма: {chislo+prost}");
Console.WriteLine($"разность: {chislo - prost}");
Console.WriteLine($"произведение: {chislo * prost}");
Console.WriteLine($"деление на цело: {chislo / prost}");
Console.WriteLine($"возведение в степень: {Math.Pow(chislo, prost)}");
Console.WriteLine($"корень числа prosto: {Math.Sqrt(chislo)}");
Console.WriteLine($"деление на остаток: {chislo % prost}");

int[] arr = new int[chislo];

Random rnd = new Random();

for (int i = 0; i < chislo; i++)
{
    arr[i] = rnd.Next(0, 100);
    Console.Write($"{arr[i]}  ");
}