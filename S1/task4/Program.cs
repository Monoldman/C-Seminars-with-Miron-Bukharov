// Задача 4 условие: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//  Console.WriteLine("Вам нужно ввести три числа");
// Console.WriteLine("Введите первое число");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int userNumber3 = Convert.ToInt32(Console.ReadLine());
// if (userNumber1 > userNumber2 && userNumber1 > userNumber3){Console.WriteLine("максимальное число " + userNumber1);}
// else if (userNumber2 > userNumber1 && userNumber2 > userNumber3){Console.WriteLine("максимальное число " + userNumber2);}
// else {Console.WriteLine("максимальное число " + userNumber3);}



/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
void PrintArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FillArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Math.Round((new Random().NextDouble()) * 5, 1);
    }
  }
}

double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);

*/



/* неправильная скорее весего
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int Prompt(string message)
{
  Console.Write(message);
  var readInput = Console.ReadLine();
  int result = Convert.ToInt32(readInput);
  return result;
}

int[,] CreatArray(int m = 3, int n = 4)
{
  int[,] matrix = new int[m, n];
  return matrix;
}

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 20);
    }
  }
  return arr;
}

string FindNumber(int[,] matr)
{
  int findNum = Prompt("Введите число для поиска: ");
  string result = string.Empty;

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i, j] == findNum)
      {
        result = result + $" {findNum} на позиции [{i}, {j}]";
      }
    }
  }
  return result == "" ? $"{findNum} нет в матрице" : result;
}

int[,] matr = CreatArray();
matr = FillArrayRandom(matr);
PrintArray(matr);
Console.WriteLine(FindNumber(matr));

*/




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j],3} ");
    }
    Console.WriteLine();
  }
}

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
}

double[] FindAverage(int[,] matr)
{
  double[] averageMatr = new double[matr.GetLength(1)];

  for (int j = 0; j < matr.GetLength(1); j++)
  {
    double averageNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      averageNum += (matr[i, j]);
    }
    averageMatr[j] = Math.Round(averageNum / matr.GetLength(0), 2);
  }
  return averageMatr;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(string.Join("  ", FindAverage(matrix)));





 
 