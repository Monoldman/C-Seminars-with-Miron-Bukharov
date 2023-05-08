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


int[,] RemoveMinRowColumn(int[,] matrix, int minInRow, int minInColumn) // ФУНКЦИЯ удаления строки и колонки из массива на пересечении мин чисел
{                                                                   // int minRow, int minColumn предаем мин занчение в массиве  
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]; // Создаем массив меньше на строчку и колонку
    int m = 0, n = 0; //счетчики для массива  
    for (int i = 0; i < newMatrix.GetLength(0); i++) //двигаемся по новому массиву
    {
        if (m == minInRow) m++; // счетчик минимального ряда 
        for (int j = 0; j < newMatrix.GetLength(1); j++) ////двигаемся по новому массиву 
        {
            if (n == minInColumn) n++;
            newMatrix[i, j] = matrix[m, n];//создаем счетчики с минимальными индексами  
            n++; //счетчик по столбцам
        }
        m++; //счетчик по строкам  
        n = 0; //обнуляет столбцы, чтобы двигаться по строкам   
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

