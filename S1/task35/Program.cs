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

