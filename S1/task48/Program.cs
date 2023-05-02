// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(row_num, column_num);
Print(mass);


int[,] MassNums(int row, int column) // ФУНКЦИЯ созд рандомного массива строки/слолбцы/лев граница/прав граница 
{
int[,] array = new int[row, column]; // двумерный массив 

for (int i = 0; i < row; i++) // счеткик, который бегает по строкам
for (int j = 0; j < column; j++) // счеткик, который бегает по столбцам
array[i, j] = i+j; //array[i, j] - указывает на каком элементе массива находится счетчик 
return array;                                 
}                                             

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

