//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Понедельник, рабочий день"); break;
    case 2: Console.WriteLine("Вторник, рабочий день"); break;
    case 3: Console.WriteLine("Среда, рабочий день"); break;
    case 4: Console.WriteLine("Четверг, рабочий день"); break;
    case 5: Console.WriteLine("Пятница, рабочий день"); break;
    case 6: Console.WriteLine("Суббота, выходной"); break;
    case 7: Console.WriteLine("Воскресение, выходной"); break;
}