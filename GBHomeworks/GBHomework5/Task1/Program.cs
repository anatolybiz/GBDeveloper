// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
	int[] array = new int[size];
        Console.Write("Массив [");
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
	}

int HowManyEvenNumbers(int[] array)
{
	int evenNumber = 0;

	for (int i = 0; i < array.Length; i++)
	{
			if (array [i] % 2 == 0)
				evenNumber++;
            else evenNumber = evenNumber;
	}

	return evenNumber;
}


int[] array = CreateArray(10);
Console.WriteLine();
Console.WriteLine($"Количество четных значений: " + (HowManyEvenNumbers(array)));