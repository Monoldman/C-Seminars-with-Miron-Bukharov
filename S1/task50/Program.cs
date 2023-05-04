
// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 

int rowIndex = GetIndex("Введите индекс строки: ");
int columnIndex = GetIndex("Введите индекс столбца: ");

int[,] array2D = new int[4, 3];
GetRandomArray2D(array2D);
PrintArray2D(array2D);

if (rowIndex < array2D.GetLength(0) && columnIndex < array2D.GetLength(1)) Console.WriteLine(array2D[rowIndex, columnIndex]);
// если индекс ряда меньше длины ряда и индекс колонки меньше длинны колонки -> вывести число массива под этими индексами
else Console.WriteLine($"{rowIndex}{columnIndex} -> такого числа в массиве нет");




void GetRandomArray2D(int[,] array) // ФУНКЦИЯ генерации РАНДОМНОГО двумерного массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++) 
         {
            array[i, j] = new Random().Next(1,10); // полуинтервал от [1 до 10)
         }
    } 
}

int GetIndex(string message)  // ФУНКЦИЯ принримает значение от пользователя 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив  
{
int row = array.GetLength(0);// возвращает кортеж 
int column = array.GetLength(1);

for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
Console.Write($" {array[i, j], 4} "); // не дает слипнуться  
Console.WriteLine(); // для перевода курсора на следующую строку
}
Console.WriteLine();// не дает слипнуться  
}



