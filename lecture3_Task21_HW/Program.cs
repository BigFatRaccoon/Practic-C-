// Напишите программу, которая принимает на вход координаты трёх точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите координату х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату х2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату z1 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
    return result;
}
double res = Math.Round(Dist(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);