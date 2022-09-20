// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num <=1) Console.WriteLine("Чётные числа отсутствуют");
if (num % 2 < 0) num = num-1;
else
while (count <= num)
{
    Console.Write($"{count}, ");
    count += 2;
    
}