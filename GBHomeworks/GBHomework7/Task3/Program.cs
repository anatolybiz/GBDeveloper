// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    Random rndm = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndm.Next(1, 10);
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
              Console.Write($"{array[i,j]}   ");
        }
      Console.WriteLine();
    } 
    
} 



void ArithMeanColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {  
        double arithMean = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithMean = arithMean + array[i, j]; 
        }
        Console.WriteLine("Среднее арифметическое столбца {0} является : {1}  ", j, (Math.Round(arithMean / array.GetLength(0), 2))); 
    } 
}

int[,] array = GetArray(3, 3); 
PrintArray(array);
Console.WriteLine();
ArithMeanColumn(array);
