// double - переменная типа данных(контейнер)б число с остатком, а не только целое
// деление двух чисел
Console.WriteLine("Введите первое число "); //показывает текст Введите первое число
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Частное двух чисел составляет: {numberA / numberB}");