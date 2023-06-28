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
string DecimalToBinary(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

System.Console.WriteLine("Enter number ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"NUmber {num} in binary system -> {DecimalToBinary(num)}");