// Показать третью цифру из трехзначного числа, либо вывести на экран, что ее нет
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99)
{
    Console.WriteLine(n > 99 ? n.ToString()[2] : '-');

}
else if (n < -99)
{
    Console.WriteLine(n < -99 ? n.ToString()[3] : '-');

}
else
{
    Console.WriteLine("Третьей цифры нет");
}