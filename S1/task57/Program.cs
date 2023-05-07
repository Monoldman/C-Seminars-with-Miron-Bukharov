// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.



Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);
ReplaceRowsToColumns(array); 
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
      array[i, j] = new Random().Next(-5, 5);
    }
  }
}

void ReplaceRowsToColumns(int[,] array) //Метод меняет строки на колонки 
{
    int length = array.GetLength(0); //длина для строк и столбцов будет одинаковая 

        for (int i = 0; i < length; i++) //length - 1 вводится чтобы не было двойной замены
        {
            for (int j = 0; j < i; j++) //i + 1 вводится, чтобы не было двойной замены
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
}
