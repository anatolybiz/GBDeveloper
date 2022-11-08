// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Arrow();
void Arrow()
{
    int[] N = new int[8];
        Console.Write("Массив [");
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(0,99);
        Console.Write($"{N[i]} ");
    }
    Console.Write("]");
}