﻿// Задача 40: Нпишите программу, которая принимает 3 числа
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

bool IsTriangleExist(int a, int b, int c) //Функиця ло гическая возваращающая да или нет, проверяет теорема о неравенстве треугольника
{
    
    if (a + b < c || a + c < b || b + c < a)
        return false;
    // if (a + b < c)
    //     return false; 
    // else if (a + c < b)
    //     return false; 
    // else if (b + c < a)
    //     return false;   
    else
        return true;     
}   