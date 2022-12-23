

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void NaturalAllNumber (int N)
// {
//     if (N >= 1) 
//     {
//         NaturalAllNumber(N - 1); 
        
//         Console.Write(N + " ");     
//     }
// }
// Console.Write("Please input N -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// NaturalAllNumber(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumNum(int m, int n)
// {
//     if (n < m) 
//     {
//         return 0;
//     }
//     else
//     {
//         return n + SumNum(m, n - 1);
//     }
// }

// Console.Write("Please input number M -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input number N -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {n} -> {SumNum(m,n)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int akkerm(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = akkerm(n, m - 1);
        }
        n = n - 1;
    }
    return m + 1;
}
Console.Write("Please input number n -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {n}, n = {m} -> {akkerm(n, m)}");
