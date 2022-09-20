// Написать программу, которая будет выдавать названия дня недели, по заданному номеру.
// 3 - Среда
// 5 - Пятница

Console.Write("введите число от 1 до 7: ");
int num  = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.WriteLine(" Понедельник");
if (num == 2) Console.WriteLine(" Вторник");
if (num == 3) Console.WriteLine(" Среда");
if (num == 4) Console.WriteLine(" Четверг");
if (num == 5) Console.WriteLine(" Пятница");
if (num == 6) Console.WriteLine(" Суббота");
if (num == 7) Console.WriteLine(" Воскресенье");
if (num > 7) Console.WriteLine(" Неверное значение");