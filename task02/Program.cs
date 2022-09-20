Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int square = num2 * num2;
if (num1 == square)
{
    Console.WriteLine($"{num2} является корнем {num1}");
}
else
{
    Console.WriteLine($"{num2} не является корнем {num1}");
}