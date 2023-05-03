// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12




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
SumDiag(mass);
Console.WriteLine(SumDiag(mass));

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
                    Console.Write($" {array[i, j],4} "); // не дает слипнуться  
                Console.WriteLine(); // для перевода курсора на следующую строку
            }
            Console.WriteLine();// не дает слипнуться  
        }


int SumDiag(int[,] array) // ФУНКЦИЯ выводит сумму числе главной диагонали  
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i ++)
               {
                    for (int j = 0; j < array.GetLength(0); j ++)
                        {
                            if(i==j)
                                {
                                   count = count + array[i,j];
                                }
                        }

                }
            return count;
        }
