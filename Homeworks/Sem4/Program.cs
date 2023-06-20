// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int DegreeNumber (int a, int b)
// {
//     int degree = a;
//     for(int i = 1; i < b; i++)
//     {
//         degree = degree * a;
//     }
//     return degree;
// }
// System.Console.WriteLine("Enter A number ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a natural B number ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a}, {b} -> {DegreeNumber(a, b)}");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int a)
{
    int current = 0;
    for (int i = 1; a < 0; i++)
    {
        a = a % 10;
        current = i;
    }
    return current;
}

System.Console.WriteLine("Enter a number ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{a} -> {SumDigits(a)}");