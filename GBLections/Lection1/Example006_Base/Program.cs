int num1 = new Random().Next(1, 10); //генерирует случайное число
Console.WriteLine(num1);  //показывает какое число загадали
int num2 = new Random().Next(1, 10);
Console.WriteLine(num2);
int num3 = new Random().Next(1, 10);
Console.WriteLine(num3);
int num4 = new Random().Next(1, 10);
Console.WriteLine(num4);
int num5 = new Random().Next(1, 10);
Console.WriteLine(num5);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
if(num4 > max) max = num4;
if(num5 > max) max = num5;
Console.Write("Максимальное число = ");
Console.WriteLine(max);