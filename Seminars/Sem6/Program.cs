// Задача 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }

// System.Console.WriteLine("Enter array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);

// myArray = ReverseArray(myArray);
// PrintArray(myArray);

// Написать метод, который переводит число в двоичную систему исчисления.
// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;
//     }
//     return result;
// }

// System.Console.WriteLine("Enter number ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"NUmber {num} in binary system -> {DecimalToBinary(num)}");

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, 
// а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// int[] FibonacciNumbers(int size, int a, int b)
// {
//     int[] array = new int[size];
//     array[0] = a;
//     array[1] = b;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[(i - 1)] + array[(i - 2)];
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

// System.Console.WriteLine("Enter num a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter num b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// PrintArray(FibonacciNumbers(10, a, b));

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник со сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

bool CheckTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

if (CheckTriangle(4, 5, 6)) System.Console.WriteLine("Triangle with these sides can exist");
else System.Console.WriteLine("Triangle with these sides can't exist");;
