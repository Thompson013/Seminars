// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Create3DigitArray(int size, int minValue, int maxValue)
// {
//     int[] RandomArray = new int[size];
//         for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(100, 1000);
//     }
//     return RandomArray;
// }

// int FindEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] number)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         System.Console.Write(number[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] myArray = new int[5];
// myArray = Create3DigitArray(5, 100, 999);
// PrintArray(myArray);
// System.Console.WriteLine($"Numbers of even figures of array -> " + FindEvenNumber(myArray));

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] RandomArray = new int[size];
//         for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return RandomArray;
// }

// int FindSum(int[] RandomArray)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < RandomArray.Length)
//     {
//         sum = sum + RandomArray[i];
//         i = i + 2;
//     }
//     return sum;
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
// int[] myArray = new int[4];
// myArray = CreateRandomArray(4, 1, 9);
// PrintArray(myArray);
// System.Console.WriteLine($"Sum of elements in odd positions -> " + FindSum(myArray));

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Double[] FindArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    return numbers;
}

Double FindMinMax(double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}
Console.WriteLine("Enter array size  ");
int size = Convert.ToInt32(Console.ReadLine());
double min = Int32.MinValue;
double max = Int32.MaxValue;
double[] numbers = new double[size];
FindArray(numbers);
FindMinMax(numbers);
Console.WriteLine("array is: ");
PrintArray(numbers);
System.Console.WriteLine($"Maximal element {max}, minimal element {min}");
System.Console.WriteLine($"the difference between maximal and minimal elements -> {max - min}");


// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

