// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 & day <= 5) Console.WriteLine("Не повезло :( Топай работать");
if (day == 6 | day == 7) Console.WriteLine("Выходной");
if (day > 7 | day < 1) Console.WriteLine("Введите корректное число, от 1 до 7");