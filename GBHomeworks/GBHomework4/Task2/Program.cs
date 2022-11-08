//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
string str = n.ToString();
int[] b = new int[str.Length];
int result = 0;
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
     result = result + b[i];
}
Console.WriteLine(result);