//адача 44: Не используя рекурсию, введите первые N чисел Фибаначи. Первые два числа Фибаначи: 0 и 1.
// Если N = 5 -> 0,1,1,2,3
// Если N = 3 -> 0,0,1
// Если N = 7 -> 0,1,1,2,3,5,8



Console.Clear();

int n = ReadNumberFromConsole("Введите количество чисел Фибаначи");

int[] fibArray = GetFibNumbers(n);
PrintArray(fibArray);


int[] GetFibNumbers (int n) // ФУНКИЦЯ преобразования массива
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


 

