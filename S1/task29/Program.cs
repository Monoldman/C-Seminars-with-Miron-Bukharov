/*Задача 29: 
Напишите программу, которая приниматет на вход длину массива, 
минимальное значение массива и максимальное значение массива, 
создаёт массив с заданными параметрами и выводит значения на экран
5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]*/


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









