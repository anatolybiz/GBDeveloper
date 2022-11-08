// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76

double[] CreateArray(int size)
{
	double[] array = new double[size];
        Console.Write("Массив [");
        Random rnd = new Random();
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(rnd.Next(-100, 100) + rnd.NextDouble(), 2);
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
	}

double FindMin(double[] array)
{
    double min = double.MaxValue;
    foreach (var i in array) {
        if (i < min) {
            min= i;
        }
     }
    return min;
}
 
double FindMax(double[] array)
{
    double max = double.MinValue;
    foreach (var i in array) {
        if (i > max) {
            max = i;
        }
    }
    return max;
}    


double[] array = CreateArray(10);
Console.WriteLine();
Console.WriteLine($"Разница между max и min: " + (Math.Round((FindMax(array) - FindMin(array)), 2)));