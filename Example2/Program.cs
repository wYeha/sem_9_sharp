//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

int SumNaturalNumbers(int M, int N)
{
    if (M == N)
    {
        return M;
    }

    else
    {
        return M + SumNaturalNumbers(M + 1, N);
    }
}

int M = 2;
int N = 3;
int sum = SumNaturalNumbers(M, N);
Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);