/* Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

int[,] GetArray(int[,] array)

{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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



void SortString(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {        
                if (array[i, z] < array[i, z + 1])
                    {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                    }          
            }
        } 
    }
}

GetArray (array);
Console.WriteLine();
Console.WriteLine("Массив до: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
SortString(array);
PrintArray(array);
