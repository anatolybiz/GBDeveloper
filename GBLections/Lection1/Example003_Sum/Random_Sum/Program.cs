// new Random().Next(min, max) даст случайное целое число от min до max-1 (за то, что это будут целые числа отвечает Next)
int numberA = new Random().Next(1, 10); // продолжение. [min, max-1] или [min, max) . 1,2,3,4 ... 9 - макс будет 9
Console.WriteLine(numberA); // показать какое число было загадано для numberA
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB); // показать какое число было загадано для numberB
int result = numberA + numberB;
Console.WriteLine(result);