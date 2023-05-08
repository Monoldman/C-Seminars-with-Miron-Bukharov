//Задача 57:
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);

int[] arr = MatrixToArray(array);
System.Console.WriteLine();

Array.Sort(arr);
System.Console.WriteLine();
FreqDictionary(arr);


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

int[] MatrixToArray(int[,] array) //Функция конвертации двухмерного массива в одномерный 
{
    int [] collection = new int [array.Length];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            collection [count] = array[i,j];
            count++;
        }

    }
    return collection;
}

void FreqDictionary(int[] array)//Функция считает частотность элементов в 2х мерном массиве
{
int count = 1;
int currentNum = array[0];
for (int i = 1; i < array.Length; i++)
{
if (array[i] == currentNum)
{
count++;
}
else
{
Console.WriteLine($"число  {currentNum}   встречается раз: {count}");
currentNum = array[i];
count = 1;
}
}
Console.WriteLine($"число  {currentNum}   встречается раз: {count}");
}


