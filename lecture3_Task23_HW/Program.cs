// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"|{count, 3}|  {count * count * count, 5} |");
        count++;
    }
}

if (num > 0) Cube(num);
else Console.WriteLine("Введено верное значение! ");