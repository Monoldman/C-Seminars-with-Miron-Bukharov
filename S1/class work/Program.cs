﻿/*
                     РАБОТА С МАССИВАМИ: 
1) ВВОДИМ МАССИВ 
3) ВЫВОДИМ В КОНСОЛЬ ИЗНАЧАЛЬНЫЙ МАССИВ 
4) ВЫВОДИМ В КОНСОЛЬ ИЗМЕНЕННЫЙ  МАССИВ 
2) ПИШЕМ ФУНКЦИЮ, КОТОРАЯ ОБРАБАТЫВЕТ МАССИВ И ВЫДАЕТ НОВЫЕ ЗНАЧЕНИЯ   
*/

// ФУНКЦИЯ генерации случайных вещественных чисел:

// for (int i = 0; i < 10; i++)
//     {
//         double rendomNumber = new Random().NextDouble();
//         Console.WriteLine(rendomNumber);
//     }
  








/*
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
*/


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



/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] array = new int [4];   //задаем массив и его значения 
array [0] = -4; 
array [1] = -8; 
array [2] = 8; 
array [3] = 2;
PrintArray(array); //выводим массив до изменений
ChangePosIntoNeg(array); 
PrintArray(array); //выводим массив после изменений

 void ChangePosIntoNeg(int[] array)               //замена положительных на отрицательные
  {
for (int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;        
    }
  }

 void PrintArray(int[] array)                     //вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length -1; i++)
    {
    Console.Write ($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");

}
*/



/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да


int[] array = {6, 7, 19, 345, 3};
PrintArray(array);
Console.WriteLine("Введите число, которое надо найти");
int number = ReadNumberFromConsole();
bool result = FindNumberInArray(array, number); // использование функции
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 
bool FindNumberInArray(int[] array, int numberToSearch) // ФУНКИЦЯ посиск числа 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numberToSearch)
        {
            return true;
        }
    }
    return false;
}
 
void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}
 
int ReadNumberFromConsole() // ФУНКИЦЯ вывод числа 
{
    string input = Console.ReadLine();
    return int.Parse(input);
}
*/




/*
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0


int[] array = new int [123]; // задаем размер массива
FillArray(array); // задаем массив через функцию гененрации массива 
PrintArray(array);
int count = FindNumbersInArray(array, 10, 99); 
Console.WriteLine($"Количество чисел: {count}"); 

 
void FillArray(int[] array)             //ФУНКЦИЯ генерации массива 
{
   for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(0, 299);
    }

}

void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}
 
int FindNumbersInArray(int[] array, int min, int max) // ФУНКИЦЯ перебора мпссива и нахождения чисел заданного диапазона
{
    int counter = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (min <= array[i] && array[i] <= max) 
        {
          counter ++; 
        }
    }  
    return counter; 
}

*/



/* // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 



        Console.Clear();
        int[] array = new int[5]; // задаем размер массива
        FillArray(array, 1, 5); // задаем массив через функцию гененрации массива 
        PrintArray(array);
        PrintArray(MultiplyPairs(array));

        void FillArray(int[] array, int min, int max)             //ФУНКЦИЯ генерации рандомного  массива 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max + 1);  // +1  тк  Random().Next не включает последнее значение
            }

        }
        void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }
        int[] MultiplyPairs(int[] array)
        {
            int firstPointer = 0;
            int secondPointer = array.Length - 1;
            int pairPointer = 0;
            int[] pairsMultiply = new int[(array.Length +1) / 2];
            while (firstPointer < secondPointer)
            {
                pairsMultiply [pairPointer] = array[firstPointer] * array[secondPointer];
                firstPointer++;
                secondPointer--;
                pairPointer++;
            }
            if (firstPointer == secondPointer)
            {
                pairsMultiply [pairPointer] = array[firstPointer]; // *1;
            }
             return pairsMultiply;
        }


 
*/



/*    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
[345, 897, 568, 234] -> 2    */


/*
// ФУНКЦИЯ генерации случайного массива с вводдом чисел (через GetRandomArray) ВЫЗЫВАЮЩАЯ:
int length = 10;
int leftRange = 100;
int rightRange = 1000;
int[] myArray = GetRandomArray(length, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ
AllpositiveNumbers(myArray); 
int counts = AllpositiveNumbers(myArray);
Console.WriteLine($"[{string.Join(", ", counts)}]");// выводим РЕЗУЛЬТАТ 


int[] GetRandomArray(int length, int leftRange, int rightRange) //ФУНУЦИЯ генерации случайного массива ВЫЗЫВАЕМАЯ 
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}

int AllpositiveNumbers (int[] array) //ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
       
    }               
    return result;
}
 
*/




/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел:
int length = 10;
int leftRange = -20;
int rightRange = 20;
int[] myArray = GetRandomArray(length, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ

AlloddNumbers(myArray);
int counts = AlloddNumbers(myArray); //ДОПОЛНИТЕЛЬНАЯ ПЕРЕМЕННАЯ, которая запускает программу
Console.WriteLine($"[{string.Join(", ", counts)}]");// выводим РЕЗУЛЬТАТ



int[] GetRandomArray(int length, int leftRange, int rightRange) // Метод генерации случайного массива с вводдом чисел (ВЫЗЫВАЕМЫЙ):

{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}


int AlloddNumbers (int[] array) // ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ
{
    int result = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
       
    }               
    return result;
}
 
*/


// Для создания рандомного массива из вещественных чисел используется 
// метод NextDouble();  НО! этот метод не принимает никаких параметров
//  ему невозможно в скобках задать границы диапазона (1, 10) в которых 
//  будет генерироваться массив тк задается чило от 0.0 до 1.0.  
//  то есть будет интервал от 0.0 до 1.0, в который единица не включена.
//  Повлиять не это можно УМНОЖИВ интервал, например, на 100:
// NextDouble()*100; То обе границы увеличатся на 100. 

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100;
System.Console.WriteLine(  numberDouble  );
 */

// Если есть задача увеличить диапазон, например от -20 до 80
// то будет какая запись: 
// double numberDouble = Random.Shared.NextDouble() * 100 -20;
// которая будет означать, что диапазон будет 
// от 0 - 20 до 100 - 20 те от -20 до 80.  

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
System.Console.WriteLine(  numberDouble  ); 
*/

// Чтобы обрезать ЗАПЯТАЯ КОЛИЧЕСТВО ЦИФР ПОСЛЕ ЗАПЯТОЙ
//  (-8.103378777326435), нужно: ($"{   numberDouble  :f2}");
// где 2 после f -  сколько цифр после зпятой
// При этом переменная не теряет после округления, тк здесь
// меняется только вывод

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
System.Console.WriteLine($"{numberDouble:f2}" );
*/

// Вывод массива Double через СТРОЧКУ:

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
double [] doubles = new double[] {2.33539583, 1.293535, 45.32253253};
Console.WriteLine($"{string.Join (", ", doubles.Select(x => Math.Round(x, 2)))}" );
*/



/*

// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76


int length = 10;
int leftRange = -20;
int rightRange = 20;
int[] myArray = GetRandomArray(length, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ


(int max, int min) = MaxMin(myArray);
Console.WriteLine($"[{string.Join(", ", max + min)}]");


int[] GetRandomArray(int length, int leftRange, int rightRange) //ФУНКЦИЯ генерации случайного массива
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}

(int, int) MaxMin (int[] array)  // ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ:
{
    int resultMin = 0;
    int resultMax = 0;

    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i] > resultMax)
        {
            resultMax = array[i];
        }
        else if  (array[i] <= resultMin)
        {
        resultMin = array[i];
        }

    }   

    return (resultMin, resultMax);
}
 
*/

/*
// Напришите программу, которая перевернет одномерный массив (последний элемент 
//бдует на первом месте, а первый - на последнем и тд.).
//[123455] -> [54321]
//[6736] -> [6376]


int[] array = new int[] {1,2,3,4,5,6,7,8,9,0 };

PrintArray(array);
ReverseArray(array);
PrintArray(array);


void ReverseArray (int[] array)  //ФУНКЦИЯ принимает и преобразовывает массив

{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array [array.Length -i -1];
        array [array.Length -i -1] = array [i];
        array[i] = buf;
    }  
}

 void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }

*/



/*
// Задача 40: Нпишите программу, которая принимает 3 числа
// и проверяет, может ли существовать треугольник со сторонами такой длинны.
//(теорема о неравенстве треугольника: меньше сумму двух других сторон)

Console.Clear();

int a = ReadNumberFromConsole("Введите длину стороны А");
int b = ReadNumberFromConsole("Введите длину стороны B");
int c = ReadNumberFromConsole("Введите дли ну стороны C");
Console.WriteLine($"A={a}, B={b}, C={c}");

bool isTriangleExist = IsTriangleExist(a,b,c);
if(isTriangleExist)
    Console.WriteLine("Треульник существует");
else
    Console.WriteLine("Треульник не существует");    
 
void ReverseArray (int[] array)  //ФУНКЦИЯ принимает и преобразовывает массив

{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array [array.Length -i -1];
        array [array.Length -i -1] = array [i];
        array[i] = buf;
    }  
}

 void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }

 int ReadNumberFromConsole(string message = "") //string message = "" -  говорит о необязательном характере записи 
{
    if (message!= "")
        Console.WriteLine(message );
    string input = Console.ReadLine();
    return int.Parse(input); 
}

bool IsTriangleExist(int a, int b, int c) //Функиця логическая возваращающая да или нет, проверяет теорема о неравенстве треугольника



/*
// Задача 42: Напришите программму, котолрая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Clear();

int decimalNumber = ReadNumberFromConsole("Введите десятичное число");
Console.WriteLine(DecToInt(decimalNumber));    


 int ReadNumberFromConsole(string message = "") //string message = "" -  говорит о необязательном характере записи 
{
    if (message!= "")
        Console.WriteLine(message );
    string input = Console.ReadLine();
    return int.Parse(input); 
}


string DecToInt(int decimalNumber) //ФУНКЦИЯ , которая возвращает двоичное число
{   
    string result = string.Empty; // то же самое что и "" 
    while(decimalNumber > 0)
    {
        int someValue =  decimalNumber % 2;
        result = someValue.ToString() + result;
        decimalNumber /= 2;
    }
    return result;
}   







/*

//адача 44: Не используя рекурсию, введите первые N чисел Фибаначи. Первые два числа Фибаначи: 0 и 1.
// Если N = 5 -> 0,1,1,2,3
// Если N = 3 -> 0,0,1
// Если N = 7 -> 0,1,1,2,3,5,8



Console.Clear();

int n = ReadNumberFromConsole("Введите количество чисел Фибаначи");

int[] fibArray = GetFibNumbers(n);
PrintArray(fibArray);


int[] GetFibNumbers (int n) // ФУНКИЦЯ преобразования массива в чисала Фибаначи
{
    int[] result = new int[n];
    if (n >= 2)
     result[1] = 1;
    
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];   
    }
    return result;   
} 

 void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }

 int ReadNumberFromConsole(string message = "") //string message = "" -  говорит о необязательном характере записи 
{
    if (message!= "")
        Console.WriteLine(message );
    string input = Console.ReadLine();
    return int.Parse(input); 
}

*/
 

/*
// Задача 45
// Напишите программу, которая будет создавать копию данного 
// массива с помощью поэлементного копирования 

Console.Clear();
int[] array = new int[]{1,2,3,4,5,6,7,8 ,0}; //1) создаем массив
PrintArray(array); //изначальный массив
int[] newArray = CorrectCopyIncrementArray(array);
PrintArray(newArray);//новый массив
PrintArray(array);//изначальный массив


int[] WrongCopyIncrementArray(int[] array)  //4) создаем ФУНКЦИЮ в которой каждый элемент будет увеличен на единицу 
{
     for (int i = 0; i < array.Length; i++)
    {
    array [i] = array[i] +1;  
    }
    return newArray; 
} 
 
int[] CorrectCopyIncrementArray(int[] array)  //2) создаем ФУНКЦИЮ в которой каждый элемент будет увеличен на единицу 
{
    int[] newArray = new int [array.Length]; //3) создаем копию массива той же длины  
    for (int i = 0; i < array.Length; i++)
    {
    newArray[i] = array[i] +1;  
    }
    return newArray; 
} 
 
void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }

*/

/*
// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbers()
{
    int count = 0;
    string word;
    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;
    }
}

int count = CountNumbers();
Console.WriteLine($"Numbers greater than zero: {count}"); 


// 2й вариант решения

int Check(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.WriteLine("Сколько чисел хотели бы вывести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Check (a);
Console.WriteLine($"Количесво чисел больше 0: {result}");

*/


/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine($"Введите значения");  
double b_1 = double.Parse(Console.ReadLine()!);
double k_1 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);
double k_2 = double.Parse(Console.ReadLine()!);

Intersection(k_1, b_1, k_2, b_2); 

void Intersection (double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
    else if(k1 == k2 && b1 == b2)
        Console.WriteLine($"Существует бесконечное чило пересечений ");
    else
        Console.WriteLine($"Нет пересечений ");  
}
*/

// ДВУМЕРНЫЕ МАССИВЫ 

/*
int[,]matrix = new int[5,8];
int          - тип данных +  
[,]          - форма двумерного массива  
matrix       - именование массива или идентификатор массива
=            - оператор писваивания 
new int      - обязательное условие

   сколько строк 
  /   matrix.GetLength(0); - возвращает количество строк 
[5,8]        -  
    \ matrix.GetLength(1); - возвращает количество столбцов 
     сколько столбцов
*/


// Массив из строк:
// string[,]table = new string [2,3]; двумерный массив из строк new string 
// string[,]table  - тип данных string, наименование масива - table и [,] - указание на двумерность массива  
// [2,3]            - количество строчек и столбцов (инедексы меняются от 0 ):  
// string[,]table = new string [2,5]; 2 строки, 5 столбцов 
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

// string[,] table = new string[2,5];
// table[1, 2] = "слово";
// // string.Empty    инициализация строк

// for (int rows = 0; rows < 2; rows++) //количество рядов
// {
//  for (int columns = 0; columns < 5; columns++) // количество столбцов 
//  {
//  Console.WriteLine($" {table[rows, columns]}"); //распечатываем массив, вывод будет невидимиым, тк строки инициализируются устой строкой 
//  }
// }


// Массив из чисел:
// int[,]matrix = new int[5,8];  new int[5 количество строк , 8 количество слолбцов]; 

// Запуск двумерного массива с числами в строчку:

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++) //  i  -  строки
// {
//  for (int j = 0; j < 4; j++) //  j  -  столбцы
//  {
//  Console.WriteLine($"{matrix[i, j]} "); // вывод будет в одну строчку
//  }
// }
// // Запуск двумерного массива с столбиками:

// int[,] matrix = new int[3, 4]; // при инициализации массива задаем количество строк и столбцов для выделения памяти
// for (int i = 0; i < 3; i++)
// {
//  for (int j = 0; j < 4; j++)
//  {
//  Console.Write($"{matrix[i, j]} "); // вывод будет в столбик 
//  }
// Console.WriteLine();
// }

// // Запуск двумерного массива с столбиками ФУНКЦИЯ:

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//  for (int j = 0; j < matrix.GetLength(1); j++)
//  {
//  Console.Write($"{matrix[i, j]} ");
//  }
// Console.WriteLine();
// }

 /*
// // ФУНКЦИЯ заполнения и запуска двумерного массива с столбиками:
int[,] matrix = new int[3, 4];  
PrintArray(matrix); // ФУНКЦИЯ генерации двумерного массива столбиком c выводом
FillArray(matrix);  // ФУНКЦИЯ генерации РАНДОМНОГО двумерного массива 
Console.WriteLine();
PrintArray(matrix); // ВЫВОД сгенерированного РАНДОМНОГО двумерного массива

void PrintArray(int[,] matr) // ФУНКЦИЯ генерации двумерного массива столбиком
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

void FillArray(int[,] matr) // ФУНКЦИЯ генерации РАНДОМНОГО двумерного массива 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++) 
         {
            matr[i, j] = new Random().Next(1,10); // полуинтервал от [1 до 10)
         }
    } 
}

*/

// РЕКУРСИЯ - функция, которая вызывает сама себя


// Вычисление Факториала:



// факториал до 17:
// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(16)); 



// факториал после 17:
// double Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(40)); 

// double Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//  Console.WriteLine($"{i}! = {Factorial(i)}");
// }


/*
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.

//  1   4  8   19
//  5  -2  33  -2
// 77   3  8   1

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
 
*/


/*

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear(); //очищает консоль

double[,] array2D = new double[3, 4];
GetRandomDoubleArray(array2D);
PrintArray(array2D);

void PrintArray(double[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив с вещественными числами  
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

void GetRandomDoubleArray(double[,] array) //ФУНКЦИЯ созд рандомного массива c вещественными числами
*/



/*
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
array[i, j] = i+j; //array[i, j] - - заполняющая строчка указывает на каком элементе массива находится счетчик  
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

*/




/*
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
*/




/*

// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 

int rowIndex = GetIndex("Введите индекс строки: ");
int columnIndex = GetIndex("Введите индекс столбца: ");

int[,] array2D = new int[4, 3];
GetRandomArray2D(array2D);
PrintArray2D(array2D);

if (rowIndex < array2D.GetLength(0) && columnIndex < array2D.GetLength(1)) Console.WriteLine(array2D[rowIndex, columnIndex]);
// если индекс ряда меньше длины ряда и индекс колонки меньше длинны колонки -> вывести число массива под этими индексами
else Console.WriteLine($"{rowIndex}{columnIndex} -> такого числа в массиве нет");




void GetRandomArray2D(int[,] array) // ФУНКЦИЯ генерации РАНДОМНОГО двумерного массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++) 
         {
            array[i, j] = new Random().Next(1,10); // полуинтервал от [1 до 10)
         }
    } 
}

int GetIndex(string message)  // ФУНКЦИЯ принримает значение от пользователя 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив  
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
*/







/*
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

int SumDiag(int[,] array)

*/


/*
// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Решение 2:

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
Console.WriteLine(GeneralDiagonal(mass));


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

int GeneralDiagonal(int[,] arr)

*/





/*
// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);
Console.WriteLine(string.Join("  ", FindAverage(array)));


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
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

double[] FindAverage(int[,] array) // ФУНКЦИЯ находит среднее арифм. в столбцах двумерного массива
{
  double[] averageColumn = new double[array.GetLength(1)];

  for (int j = 0; j < array.GetLength(1); j++)
  {
    double averageNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      averageNum += (array[i, j]);
    }
    averageColumn[j] = Math.Round(averageNum / array.GetLength(0), 1);
  }
  return averageColumn;
}

*/


/*
// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.




Console.Clear(); //очищает консоль

int[,] array = new int[4, 4];
GetRandomArray(array); 
PrintArray(array);
ReplaceFirstLastRows(array); 
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
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void ReplaceFirstLastRows(int[,] array) //Метод меняет первую строку массива и последнюю
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i]; // array[array.GetLength(0) - 1, i] - указывает на конкретный элемент массива
        array[array.GetLength(0) - 1, i] = temp;        // array[array.GetLength(0)-1  количество элементов в массива -1, чтобы указать индекс
    }
}
*/




// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2





/*
int[,] matrix = new int[3, 4];
GetRandomArray (matrix);
PrintArray(matrix);
SortToLower(matrix);
PrintArray(matrix);


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

void SortToLower(int[,] array) // ФУНКЦИЯ сортировки элементов Matrix к меньшему
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int element = 0; element < array.GetLength(1) - 1; element++)
            {
                if (array[i, element] < array[i, element + 1])
                {
                    int temp = array[i, element + 1];
                    array[i, element + 1] = array[i, element];
                    array[i, element] = temp;
                }
            }
        }
    }
}

*/





/*
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
*/




/*
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4, 4];
GetRandomArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindRowMinSumElements(matrix);



void FindRowMinSumElements(int[,] matrix) //ФУНКЦИЯ поиска и вывода строки с минимальной суммой чисел
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка"); // указывает на правильную строку от нулевого индекса
}

 void GetRandomArray(int[,] matrix) // ФУНКЦИЯ cсоздает рандомный двумерный массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 9);
    }
  }
}

void PrintArray(int[,] matrix) // ФУНКЦИЯ выводит преобразованный двумерный массив  
{
int row = matrix.GetLength(0);// возвращает кортеж 
int column = matrix.GetLength(1);

for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
Console.Write($" {matrix[i, j], 2} "); // не дает слипнуться  
Console.WriteLine(); // для перевода курсора на следующую строку
}
Console.WriteLine();// не дает слипнуться  
}


*/






/*
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
*/



/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] firstArray = CreateArray(InsertNumber("Введите количество строк массива 1: "), InsertNumber("Введите количество столбцов массива 1: "));
int[,] secondArray = CreateArray(InsertNumber("Введите количество строк массива 2: "), InsertNumber("Введите количество столбцов массива 2: "));
Console.WriteLine("Первый массив:");
GetRandomArray(firstArray);
PrintArray(firstArray);
Console.WriteLine("Второй массив:");
GetRandomArray(secondArray);
PrintArray(secondArray);
Console.WriteLine("Результирующая матрица:");
int[,] newArray = MultiplyArray(firstArray, secondArray);
PrintArray(newArray);


int InsertNumber(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n) // ФУНКЦИЯ создает массив
{
  int[,] array = new int[m, n];
  return array;
}

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

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray) // ФУНКЦИЯ умножения массивов мнежу собой 
{
  int newRow, newColumn;
  if (firstArray.GetLength(0) > secondArray.GetLength(0))
  {
    newRow = secondArray.GetLength(0);
  }
  else
  {
    newRow = firstArray.GetLength(0);
  }
  if (firstArray.GetLength(1) > secondArray.GetLength(1))
  {
    newColumn = secondArray.GetLength(1);
  }
  else
  {
    newColumn = firstArray.GetLength(1);
  }

  int[,] newArray = new int[newRow, newColumn];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newColumn; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArray[i, e] * secondArray[e, j]; // формула умножения массивов
      }
    }
  }
  return newArray;
}
*/





/*
// М А С С И В  Ы:

int [] array1 = new int [0];          // одномерный массив
int [,] array2 = new int [0,1];       // двумерный массив
int [,,] array3 = new int [0,1,1];    // трехмерный массив (редко используется)

for (int i = 0; i < array3.GetLength(0); i++) // трехмерный массив
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            array3 [i,j,k] = new Random().Next(10,40);
        }
    }
}
*/



 /*
// Ф  У  Н  К  Ц  И  И :


int[] GetFibNumbers (int n) // ФУНКИЦЯ преобразования массива (Фибаначи)
{
    int[] result = new int[n];
    if (n >= 2)
     result[1] = 1;
    
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];   
    }
    return result;   
} 

 int ReadNumberFromConsole(string message = "") //string message = "" -  говорит о необязательном характере записи 
{
    if (message!= "")
        Console.WriteLine(message );
    string input = Console.ReadLine();
    return int.Parse(input); 
}

int[] GetRandomArray(int length, int leftRange, int rightRange) //ФУНКЦИЯ генерации случайного массива
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}

 int ReadNumberFromConsole(string message = "") //ФУНКИЦЯ считывает число с консоли 
{
    if (message!= "")
        Console.WriteLine(message );
    string input = Console.ReadLine();
    return int.Parse(input); 
}

 void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[^1] + "}");
        }

int[] GetFibNumbers (int n) // ФУНКИЦЯ преобразования массива в чисала Фибаначи

{
    int[] result = new int[n];
    if (n >= 2)
     result[1] = 1;
    
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];   
    }
    return result;   
} 

string DecToInt(int decimalNumber) //ФУНКЦИЯ , которая возвращает двоичное число
{   
    string result = string.Empty; // то же самое что и "" 
    while(decimalNumber > 0)
    {
        int someValue =  decimalNumber % 2;
        result = someValue.ToString() + result;
        decimalNumber /= 2;
    }
    return result;
}   

void ReverseArray (int[] array)  //ФУНКЦИЯ переворачивает массив 

{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array [array.Length -i -1];
        array [array.Length -i -1] = array [i];
        array[i] = buf;
    }  
}

(int, int) MaxMin (int[] array)  // ФУНУЦИЯ находит разницу между мин и макс
{
    int resultMin = 0;
    int resultMax = 0;

    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i] > resultMax)
        {
            resultMax = array[i];
        }
        else if  (array[i] <= resultMin)
        {
        resultMin = array[i];
        }

    }   

    return (resultMin, resultMax);
}

int[] IncrementArray(int[] array)  //2) создаем ФУНКЦИЮ в которой каждый элемент будет увеличен на единицу 
{
    int[] newArray = new int [array.Length]; //3) создаем копию массива той же длины  
    for (int i = 0; i < array.Length; i++)
    {
    newArray[i] = array[i] +1;  
    }
    return newArray; 
} 
 
void PrintArray(int[,] matr) // ФУНКЦИЯ генерации двумерного массива столбиком
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

void NewArr(int[,] array) // ФУНКЦИЯ находит два нечетных индекса и меняет их на их квадраты  
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

void GetRandomDoubleArray(double[,] array) //ФУНКЦИЯ созд рандомного массива c вещественными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Math.Round((new Random().NextDouble()) * 5, 1); // Math.Round( *5, 1) - округление, до 5 в целой части и до 1 в дробной  
    }
  }
}

void PrintArray(double[,] array) // ФУНКЦИЯ красиво выводит преобразованный двумерный массив с вещественными числами  
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

void GetRandomArray2D(int[,] array) // ФУНКЦИЯ генерации РАНДОМНОГО двумерного массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++) 
         {
            array[i, j] = new Random().Next(1,10); // полуинтервал от [1 до 10)
         }
    } 
}



Console.Clear(); //очищает консоль

void GetRandomArray(int[,] array) // ФУНКЦИЯ cсоздает рандомный двумерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
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



int rows = 4;
int columns = 4;
int min = 1;
int max = 9;
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



double[] FindAverage(int[,] array) // ФУНКЦИЯ находит среднее арифм. в столбцах двумерного массива
{
  double[] averageColumn = new double[array.GetLength(1)];

  for (int j = 0; j < array.GetLength(1); j++)
  {
    double averageNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      averageNum += (array[i, j]);
    }
    averageColumn[j] = Math.Round(averageNum / array.GetLength(0), 1);
  }
  return averageColumn;
}

int SumDiag(int[,] array) // ФУНКЦИЯ выводит сумму чисел главной диагонали  
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

void ReplaceFirstLastRows(int[,] array) //Метод меняет первую строку массива и последнюю
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i]; // array[array.GetLength(0) - 1, i] - указывает на конкретный элемент массива
        array[array.GetLength(0) - 1, i] = temp;        // array[array.GetLength(0)-1  количество элементов в массива -1, чтобы указать индекс
    }
}

void ReplaceRowsToColumns(int[,] array) //Метод меняет строки на колонки 
{
    int length = array.GetLength(0);

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
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

void SortToLower(int[,] array) // ФУНКЦИЯ сортировки элементов Matrix к меньшему
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int element = 0; element < array.GetLength(1) - 1; element++)
            {
                if (array[i, element] < array[i, element + 1])
                {
                    int temp = array[i, element + 1];
                    array[i, element + 1] = array[i, element];
                    array[i, element] = temp;
                }
            }
        }
    }
}

void FindRowMinSumElements(int[,] matrix) //ФУНКЦИЯ поиска и вывода строки с минимальной суммой чисел
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка"); // указывает на правильную строку от нулевого индекса
}

int[,] firstArr = CreateArray(InsertNumber("Введите количество строк массива: "), InsertNumber("Введите количество столбцов массива: "));
int[,] CreateArray(int m, int n) // ФУНКЦИЯ создает массив
{
  int[,] array = new int[m, n];
  return array;
}

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray) // ФУНКЦИЯ умножения массивов мнежу собой 
{
  int newRow, newColumn;
  if (firstArray.GetLength(0) > secondArray.GetLength(0))
  {
    newRow = secondArray.GetLength(0);
  }
  else
  {
    newRow = firstArray.GetLength(0);
  }
  if (firstArray.GetLength(1) > secondArray.GetLength(1))
  {
    newColumn = secondArray.GetLength(1);
  }
  else
  {
    newColumn = firstArray.GetLength(1);
  }

  int[,] newArray = new int[newRow, newColumn];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newColumn; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArray[i, e] * secondArray[e, j]; // формула умножения массивов
      }
    }
  }
  return newArray;
}

*/




