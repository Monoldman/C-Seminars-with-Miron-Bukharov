/*    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
[345, 897, 568, 234] -> 2    */





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
 


























