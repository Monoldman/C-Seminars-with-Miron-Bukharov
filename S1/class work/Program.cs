
//                      РАБОТА С МАССИВАМИ: 
//1) ВВОДИМ МАССИВ 
//3) ВЫВОДИМ В КОНСОЛЬ ИЗНАЧАЛЬНЫЙ МАССИВ 
//4) ВЫВОДИМ В КОНСОЛЬ ИЗМЕНЕННЫЙ  МАССИВ 
//2) ПИШЕМ ФУНКЦИЮ, КОТОРАЯ ОБРАБАТЫВЕТ МАССИВ И ВЫДАЕТ НОВЫЕ ЗНАЧЕНИЯ   

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new int [4];   //задаем массив и его значения 
array [0] = -4; 
array [1] = -8; 
array [2] = 8; 
array [3] = 2;
// PrintArray(array);           //выводим изначальный массив в консоль (работает из без этой строчки)
ChangePosIntoNeg(array);     //Используем функцию замены положительных на отрицательные (обращается к массиву)
PrintArray(array);           //выводим измененный массив в консоль (не принимает VOID)

 void ChangePosIntoNeg(int[] array)               //ФУНКЦИЯ замены положительных на отрицательные
  {
for (int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;        
    }
  }

 void PrintArray(int[] array)                     //ФУНКЦИЯ вывода массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length -1; i++)
    {
    Console.Write ($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");

}



/*
Функция для считывания числовых значений с консоли:

Console.WriteLine("Введите длинну массива ");
int n = ReadNumbersFromConsole(); 
int[] myArray = new int [n];

Console.WriteLine("Введите минимальное значение элемента массива ");
int min = ReadNumbersFromConsole(); 
 Console.WriteLine("Введите максимальное значение элемента массива ");
int max = ReadNumbersFromConsole(); 


int ReadNumbersFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}
 

int length = 12; 
int leftRange = 1;
int rightRange = 100;
int[] myArray = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", myArray)}]");


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}



*/




/*ФУНКЦИИ С ВEТВЛЕНИЕМ


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
 // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] array = new int [12];
FillArray(array);
PrintArray(array);
 Console.WriteLine($"Сумма положительных чисел = {PosSum(array)} ");
 Console.WriteLine($"Сумма отрицательных чисел = {NegSum(array)} ");


void FillArray(int[] array)             //генерация массива 
{
   for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(-9, 10);
    }

}

 void PrintArray(int[] array)          //вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length -1; i++)
    {
    Console.Write ($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");

}

 int PosSum(int[] array)               //сумма положительных
  {
    int sum = 0; 
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
        
    }
    return sum;
  }

 int NegSum(int[] array)               //сумма отрицательных
  {
    int sum = 0; 
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
        
    }
    return sum;
  }

*/



