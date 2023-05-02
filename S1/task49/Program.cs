// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:

// 1 4 7 2     
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
NewArr(mass);
Print(mass);


int[,] MassNums(int row, int column, int from, int to) // ФУНКЦИЯ созд рандомного массива строки/слолбцы/лев граница/прав граница 
{
int[,] array = new int[row, column]; // двумерный массив 

for (int i = 0; i < row; i++) // счеткик, который бегает по строкам
for (int j = 0; j < column; j++) // счеткик, который бегает по столбцам
array[i, j] = new Random().Next(from, to + 1); //array[i, j] - указывает на каком элементе массива находится счетчик 
return array;                                 //new Random().Next(from, to + 1) - указывает, чем заполнять: рандом от 'from' до 'to' + 1
}                                             //new Random().Next не включается последний элемент, поэтому +1 к 'to'


void Print(int[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив  
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


void NewArr(int[,] array) // ФУНКЦИЯ находит два неччетных индекса и меняет их на их квадраты  
{
int row = array.GetLength(0);
int column = array.GetLength(1);

for (int i = 1; i < row; i += 2)
{
for (int j = 1; j < column; j += 2)
{
array[i, j] *= array[i, j];
}
}
}