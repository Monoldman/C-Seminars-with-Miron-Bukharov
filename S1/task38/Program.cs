
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
 
