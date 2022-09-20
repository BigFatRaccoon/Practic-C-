// Напишите программу, которая на входе принимает число, и выдаёт его квадрат.
// Например, 4>16, -3>-9, -7>-49

Console.Write("введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int square = number * number;
Console.WriteLine($"квадрат числа {number} = {square}");