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
 





