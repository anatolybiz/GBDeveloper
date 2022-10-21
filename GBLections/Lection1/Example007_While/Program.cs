Console.Clear();
// Console.SetCursorPosition(10, 4);  Положение отступов слева кол-во символов и сверху кол-во строк
// Console.WriteLine("+"); + будет использоваться в качестве символа

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) или же по другому числа будут генерироваться из интервала 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; //count +=1; или count++;
}