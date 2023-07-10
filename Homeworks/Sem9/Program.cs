// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNum(int n)
// {
//     if(n >= 1)
//     {
//         System.Console.Write(n + " ");
//         PrintNum(n - 1);
//     }
// }
// PrintNum(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void FindNum(int m, int n)
// {
//     if (m != n)
//     {
//         if (m <= n)
//         {
//             FindNum(m, n - 1);
//             System.Console.Write(n + " ");
//         }
//         else
//         {
//             System.Console.Write(m + " ");
//             FindNum(m - 1, n);
//         }
//     }
//     else System.Console.Write(m + " ");
// }

// int FindSum(int m, int n)
// {
//     int sum = m;
//     if(m == n)
//     {
//         return 0;
//     }
//     else
//     {
//         m++;
//         sum = m + FindSum(m, n);
//         return sum;
//     }
// }

// System.Console.WriteLine("Enter M number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter M number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// FindNum(m, n);
// System.Console.WriteLine($"-> {FindSum(m - 1,n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackerman (int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if(n == 0 && m > 0)
//     {
//         return Ackerman(m - 1, 1);    
//     }
//     else
//     {
//         return (Ackerman(m - 1, Ackerman(m, n - 1)));
//     }
// }

// System.Console.WriteLine("Enter M number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter M number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Ackerman(m, n)}");