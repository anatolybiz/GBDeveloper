// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число от 1 до 99: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] <=9)
              Console.Write($"{array[i,j]}    ");
            else
              Console.Write($"{array[i,j]}   ");

        }
      Console.WriteLine();
      Console.WriteLine();
    } 
    
}


void FindNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] == num)
                Console.WriteLine(i + " строка, " + j + " столбец");
        }
    } 
}

int[,] array = GetArray(10,10); 
PrintArray(array); 

FindNumber(array);
