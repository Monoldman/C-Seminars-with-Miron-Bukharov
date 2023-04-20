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


string DecToInt(int decimalNumber) //ФУНКЦИЯ , коиторое возвращает двоичное число
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




 