// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.WriteLine(n);
            PrintNumbers(n - 1);
        }
    }

Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());
PrintNumbers(n);