﻿// Задача 65. 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();
Console.WriteLine("Введите целое положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberM, numberN);

void NaturalNumbers(int numM, int numN)
{
if (numM < numN)
{
Console.Write($"{numM} ");
NaturalNumbers(numM+1, numN);
}
else if (numM > numN)
{
Console.Write($"{numM} ");
NaturalNumbers(numM - 1, numN);
}
else
{
Console.WriteLine(numM);
}
}