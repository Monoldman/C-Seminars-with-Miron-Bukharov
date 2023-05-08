// // Задача 59: Задайте двумерный массив из целых чисел.
// // Напишите программу, которая удалит строку и столбец, на
// // пересечении которых расположен наименьший элемент
// // массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим
// // следующий массив:
// // 9 2 3
// // 4 2 4
// // 2 6 7

Console.Clear();
int rows = 4;
int columns = 4;
int min = 1;
int max = 9;

int[,] array = GetRandomArray(rows, columns, min, max);
PrintMatrix(array);
Console.WriteLine();          // добавляет отступ
int[] massiveIdexesMinElem = MatrixMinElemIndexes(array);
PrintArray(massiveIdexesMinElem);
Console.WriteLine();
int[,] resultMatrix = RemoveMinRowColumn(array, massiveIdexesMinElem[0], massiveIdexesMinElem[1]);
Console.WriteLine();
PrintMatrix(resultMatrix);


int[,] RemoveMinRowColumn(int[,] matrix, int minRow, int minColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == minRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == minColumn) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[] MatrixMinElemIndexes(int[,] array)
{
    int rowMinElem = 0;
    int columnMinElem = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[rowMinElem, columnMinElem])
            {
                rowMinElem = i;
                columnMinElem = j;
            }
        }
    }
    return new int[] { rowMinElem, columnMinElem };
}

int[,] GetRandomArray(int rows, int columns, int min, int max) // ФУНКЦИЯ cсоздает рандомный двумерный массив c вводом извне
{
    int[,] arrayRandom = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayRandom[i, j] = new Random().Next(min, max);
        }
    }
    return arrayRandom;
}

void PrintMatrix(int[,] array) // ФУНКЦИЯ выводит преобразованный двумерный массив  
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

void PrintArray(int[] prArray) //ФУНКЦИЯ выводит одномерный массив, в данном случае индексы минимального числа
{
    for (int i = 0; i < prArray.Length; i++)
    {
        Console.Write($"{prArray[i]} ");
    }
}

