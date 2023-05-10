// Задача 67. 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(num));

int SumDigits(int n)
{
if (n == 0) return 0;
else return n % 10 + SumDigits(n / 10);
}

// Console.WriteLine("Введите число: "); // решение без рекурсии
// int number = GetIntInput();
// Console.WriteLine($"Сумма чисел: {AmountDigits(number)}");

// int GetIntInput()
// {
// string input = Console.ReadLine();
// int result = int.Parse(input);
// return result;
// }

// int AmountDigits(int a)
// {
// int sum = 0;
// int b = 0;
// while (a >= 10)
// {
// b = a % 10;
// sum = sum + b;
// a = a / 10;
// }
// if (a < 10)
// {
// sum = sum + a;
// }
// return sum;
// }

