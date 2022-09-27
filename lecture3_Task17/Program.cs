

System.Console.WriteLine( "Введите координаты точки: ");

System.Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Введите корректыне координаты" : quarter);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0 ) return 1;
    if (x < 0 && y > 0 ) return 2;
    if (x < 0 && y < 0 ) return 3;
    if (x > 0 && y < 0 ) return 4;
    return 0;
}
