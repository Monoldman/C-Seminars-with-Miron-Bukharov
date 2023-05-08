// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] firstArray = CreateArray(InsertNumber("Введите количество строк массива 1: "), InsertNumber("Введите количество столбцов массива 1: "));
int[,] secondArray = CreateArray(InsertNumber("Введите количество строк массива 2: "), InsertNumber("Введите количество столбцов массива 2: "));
Console.WriteLine("Первый массив:");
GetRandomArray(firstArray);
PrintArray(firstArray);
Console.WriteLine("Второй массив:");
GetRandomArray(secondArray);
PrintArray(secondArray);
Console.WriteLine("Результирующая матрица:");
int[,] newArray = MultiplyArray(firstArray, secondArray);
PrintArray(newArray);


int InsertNumber(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n) // ФУНКЦИЯ создает массив
{
  int[,] array = new int[m, n];
  return array;
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

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
{
  int newRow, newColumn;
  if (firstArray.GetLength(0) > secondArray.GetLength(0))
  {
    newRow = secondArray.GetLength(0);
  }
  else
  {
    newRow = firstArray.GetLength(0);
  }
  if (firstArray.GetLength(1) > secondArray.GetLength(1))
  {
    newColumn = secondArray.GetLength(1);
  }
  else
  {
    newColumn = firstArray.GetLength(1);
  }

  int[,] newArray = new int[newRow, newColumn];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newColumn; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArray[i, e] * secondArray[e, j]; // формула умножения массивов
      }
    }
  }
  return newArray;
}

