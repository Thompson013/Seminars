// int FindSum (int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// // int result = FindSum (x, y);
// // System.Console.WriteLine(result);
// System.Console.WriteLine(FindSum(x, y));

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckEven (int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WriteLine($"Number {num2} is multiple {num1}");
//     }
//     else
//     {
//         Console.WriteLine($"Number {num2} isn't multiple {num1}, reminder of division -> {num1 % num2}");
//     }
// }

// System.Console.Write("insert the first number -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("insert the second number -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven (num1, num2);

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// bool CheckEven(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// System.Console.Write("insert number -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int FindFigure (int num)
// {
//     System.Console.WriteLine(num);
//     int num1 = num / 100;
//     int num2 = num % 10;
//     int result = num1 * 10 + num2;
//     return result;   
// }

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(FindFigure(num));

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// void CheckQuad (int num1, int num2)
// {
//     if(num1 == num2 * num2)
//     {
//         Console.WriteLine($"Number {num2} is quad {num1}");
//     }
//     else
//     {
//         Console.WriteLine($"Number {num2} isn't quad {num1}");
//     }
// }
// System.Console.Write("insert the first number -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("insert the second number -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckQuad (num1, num2);