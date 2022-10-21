Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
if(username.ToLower() == "маша") // дополнение ToLower() позволяет принимать написанное имя в любом регистре, а не только Маша
{
    Console.WriteLine("Ура, это же МАША!");
}    
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}