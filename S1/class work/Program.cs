

// Функция для считывания числовых значений с консоли:

// Console.WriteLine("Введите длинну массива ");
// int n = ReadNumbersFromConsole(); 
// int[] myArray = new int [n];

// Console.WriteLine("Введите минимальное значение элемента массива ");
// int min = ReadNumbersFromConsole(); 
//  Console.WriteLine("Введите максимальное значение элемента массива ");
// int max = ReadNumbersFromConsole(); 


// int ReadNumbersFromConsole()
// {
//     string input = Console.ReadLine();
//     return int.Parse(input);
// }
 

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