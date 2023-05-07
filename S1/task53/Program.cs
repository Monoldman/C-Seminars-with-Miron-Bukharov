// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.




Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);
ReplaceFirstLastRows(array); 
PrintArray(array);
// Console.WriteLine(string.Join("  ", FindAverage(array)));


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

void GetRandomArray(int[,] array) // ФУНКЦИЯ cсоздает рандомный двумерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void ReplaceFirstLastRows(int[,] array) //Метод меняет первую строку массива и последнюю
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i]; // array[array.GetLength(0) - 1, i] - указывает на конкретный элемент массива
        array[array.GetLength(0) - 1, i] = temp;        // array[array.GetLength(0)-1  количество элементов в массива -1, чтобы указать индекс
    }
}
