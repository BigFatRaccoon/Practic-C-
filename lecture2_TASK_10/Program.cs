// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 & num < 1000)
{
    int var = num / 10;
    int var1 = var % 10;
    Console.WriteLine($"Вторая цифра числа {num} - {var1}");
}
else
{
    Console.WriteLine("Введено трехзначное число!");
}