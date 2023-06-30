// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] EnterArray(int length)
// {
//     int[] array = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(-100, 101);;
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int CountPositiveNumbers (int[] array )
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array;
// array = EnterArray(10);
// PrintArray(array);
// System.Console.WriteLine($" the quantity of elements greater than 0 -> {CountPositiveNumbers(array)}");

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter a value of b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value of k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value of b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value of k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

System.Console.Write($"The point of intersection of two straight lines -> ({x},{y})");