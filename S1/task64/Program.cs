// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




Console.Clear();
int GetUserNuber(string message) //получить число от пользователя
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int n = GetUserNuber("Введите число: ");// проверка числа, является ли оно натуральным
if (n < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}

int NaturalNumber(int n, int m)// МЕТОД рекурсия, числа от 1 до N
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

Console.WriteLine(NaturalNumber(n, 1)); // вывод всех числе до 1, включая 1 




