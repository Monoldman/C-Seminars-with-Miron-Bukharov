// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);
Console.WriteLine(string.Join("  ", FindAverage(array)));


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

double[] FindAverage(int[,] array) // ФУНКЦИЯ находит среднее арифм. в столбцах двумерного массива
{
  double[] averageColumn = new double[array.GetLength(1)];

  for (int j = 0; j < array.GetLength(1); j++)
  {
    double averageNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      averageNum += (array[i, j]);
    }
    averageColumn[j] = Math.Round(averageNum / array.GetLength(0), 1);
  }
  return averageColumn;
}



