// Задача №21.
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//   Формула нахождения расстояния между 2 точками:  d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2);


Console.WriteLine("Введите координаты первой точки по оси X");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси Y");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки Z");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки Y");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки Z");
double Z2 = Convert.ToDouble(Console.ReadLine());


double d = Math.Sqrt(Math.Pow (X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
Console.WriteLine($"{d:f2}");
