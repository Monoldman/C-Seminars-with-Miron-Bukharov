// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

 




void FillInArray(int[] collection)   
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
 
}
 
// Описание Функции, которая заполняет массив случайными числами от 0 до 1:
// void           тип возвращаемого значения
// FillInArray    название функции 
// int[]          тип данных + массив
// collection     название массива
// for (int i = 0; i < collection.Length; i++)  цикл перебора массива 
// collection[i] = new Random().Next(0, 2);    заполнение массива случайными числами от 0 до 1.



void CreateArray(int[] numbersset)
{
    for (int i = 0; i < numbersset.Length; i++)

    {
        Console.Write($"{numbersset[i]}, "); //выводит с пробелами и запятой 
     
    }
}
 
// Описание Функции, которая создает массив:
// void           тип возвращаемого значения
// CreateArray    название функции 
// int[]          тип данных + массив
// numbersset     название массива 
// for (int i = 0; i < numbersset.Length; i++) цикл перебора массива 
// Console.Write($"{numbersset[i]}, "); вывод массива .


Console.Clear(); //очищение консоли 
 

//  КОД:

int[] array = new int[8];
FillInArray(array);
CreateArray(array);

