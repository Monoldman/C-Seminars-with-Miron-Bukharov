﻿// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
if (num == 0) return;
NaturalNumbers (num - 1); // выводит последоваельно 1,2,3,4,5
Console.Write($"{num} "); //   рекурсивный вызов
//   //выводит от последнего к первому 5,4,3,2,1 ("Хвостовая рекурсия" - рекурсивный вызов находится последним)
}