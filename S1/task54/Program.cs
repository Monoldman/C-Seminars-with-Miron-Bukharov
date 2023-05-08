

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2


int[,] matrix = new int[3, 4];
GetRandomArray (matrix);
PrintArray(matrix);
SortToLower(matrix);
PrintArray(matrix);


void GetRandomArray(int[,] array) // ФУНКЦИЯ cсоздает рандомный двумерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 9);
    }
  }
}

void PrintArray(int[,] array) // ФУНКЦИЯ выводит преобразованный двумерный массив  
{
int row = array.GetLength(0);// возвращает кортеж 
int column = array.GetLength(1);

for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
Console.Write($" {array[i, j], 2} "); // не дает слипнуться  
Console.WriteLine(); // для перевода курсора на следующую строку
}
Console.WriteLine();// не дает слипнуться  
}

void SortToLower(int[,] array) // ФУНКЦИЯ сортировки элементов к меньшему
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int element = 0; element < array.GetLength(1) - 1; element++)
            {
                if (array[i, element] < array[i, element + 1])
                {
                    int temp = array[i, element + 1];
                    array[i, element + 1] = array[i, element];
                    array[i, element] = temp;
                }
            }
        }
    }
}


