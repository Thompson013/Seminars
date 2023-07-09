// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void Create2DArray(int[,] array2D)
// {
//     for (int i = 0; i <array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] GetOrderArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if(array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];
// Create2DArray(array);
// Print2DArray(array);
// GetOrderArray(array);
// System.Console.WriteLine();
// Print2DArray(array);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int FindMinRow(int [,] array)
{
    int row = 0;
    int minsum = 0;
        for (int i = 0; i < array.GetLength(1); i++) 
        {
            minsum = minsum + array[0, i];
        }
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            if(minsum > sum)
            {
                minsum = sum;
                row = i;
            }
        }
        return row;
}

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);

Console.WriteLine($"Row with the less sum - {FindMinRow(array)}");


            
            
                         
  

