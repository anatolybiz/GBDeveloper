//программа выводящая второе число из трехзначного
Console.WriteLine("Enter three number: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = (n - ((n / 100)) * 100) / 10;
Console.WriteLine($"Изначальное число {n}, вторая цифра {result}");
