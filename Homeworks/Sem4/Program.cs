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

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigits(int a)
// {
//     int sum = 0;
//     while (a != 0)
//     {
//         sum = sum + a % 10;
//         a = a / 10;
//     }
//     return sum;
// }

// System.Console.WriteLine("Enter a number ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a} -> {SumDigits(a)}");

// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Enter array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));

