﻿
/*
Функция для считывания числовых значений с консоли:

Console.WriteLine("Введите длинну массива ");
int n = ReadNumbersFromConsole(); 
int[] myArray = new int [n];

Console.WriteLine("Введите минимальное значение элемента массива ");
int min = ReadNumbersFromConsole(); 
 Console.WriteLine("Введите максимальное значение элемента массива ");
int max = ReadNumbersFromConsole(); 


int ReadNumbersFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}
 

int length = 12; 
int leftRange = 1;
int rightRange = 100;
int[] myArray = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", myArray)}]");


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}



*/




/*ФУНКЦИИ С ВEТВЛЕНИЕМ


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
 // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] array = new int [12];
FillArray(array);
PrintArray(array);
 Console.WriteLine($"Сумма положительных чисел = {PosSum(array)} ");
 Console.WriteLine($"Сумма отрицательных чисел = {NegSum(array)} ");


void FillArray(int[] array)             //генерация массива 
{
   for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(-9, 10);
    }

}

 void PrintArray(int[] array)          //вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length -1; i++)
    {
    Console.Write ($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");

}

 int PosSum(int[] array)               //сумма положительных
  {
    int sum = 0; 
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
        
    }
    return sum;
  }

 int NegSum(int[] array)               //сумма отрицательных
  {
    int sum = 0; 
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
        
    }
    return sum;
  }

*/


