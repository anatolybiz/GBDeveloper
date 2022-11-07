// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Ввод координат точки 1");
Console.WriteLine("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine());
int [] array1 = new int [] {x1,y1};
System.Console.WriteLine("Ввод координат точки 2");
Console.WriteLine("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine());
int [] array2 = new int [] {x2,y2};
System.Console.WriteLine("Ввод координат точки 3");
Console.WriteLine("Введите координату X3: ");
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y3: ");
int y3 = int.Parse(Console.ReadLine());
int [] array3 = new int [] {x3,y3};



double result = Math.Cbrt(Math.Pow (array1[0] - array2[0],2) 
                + Math.Pow (array1[1] - array2[1],2) 
                + Math.Pow (array3[0] - array3[0],2));

System.Console.WriteLine($"Результат: {result}");