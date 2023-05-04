// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear(); //очищает консоль

double[,] array2D = new double[3, 4];
GetRandomDoubleArray(array2D);
PrintArray(array2D);

void PrintArray(double[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив с вещественными числами  
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

void GetRandomDoubleArray(double[,] array) //ФУНКЦИЯ созд рандомного массива c вещественными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Math.Round((new Random().NextDouble()) * 5, 1); // Math.Round( *5, 1) - округление, до 5 в целой части и до 1 в дробной  
    }
  }
}