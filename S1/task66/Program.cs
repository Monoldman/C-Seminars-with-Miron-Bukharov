// Задача 66. 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int n = GetUserNumber("Введите число N: ");
int m = GetUserNumber("Введите число M: ");
Console.WriteLine(SumOfNaturalDigits(n, m));


int GetUserNumber(string message)// Метод получения числа от пользователя
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SumOfNaturalDigits(int n, int m) //МЕТОД рекурсии, сумма натуральных чисел  
{
  if (n == m) return n;
  else return SumOfNaturalDigits(n + 1, m) + n;
}




