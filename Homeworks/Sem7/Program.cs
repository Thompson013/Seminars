// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(-99, 100) / 10.0;
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// int rows = 5;
// int columns = 5;
// int[,] array = new int [rows, columns];

// void Create2DArray(int [,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10, 99);
//             System.Console.Write(array2D[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FindElementArray(int[,] findelement, int usernumber)
// {
//     bool find = false;
//     for (int i = 0; i < findelement.GetLength(0); i++)
//     {
//         for (int j = 0; j < findelement.GetLength(1); j++)
//         {
//             if (findelement[i, j] == usernumber)
//             {
//                 Console.WriteLine("the meaning of the element -> " + i + " " + j);
//                 find = true;
//             }
            
//         } 
//     }
//     if(!find)
//     System.Console.WriteLine("this meaning doesn't present in the array");
// }

// Console.WriteLine("Enter an element of array: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Create2DArray(array);
// FindElementArray(array, number);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int rows = 3;
// int columns = 4;
// Random random = new Random();

void Create2DArray(int[,] array2D)
{
    for (int i = 0; i <array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(0, 10);
            // System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void Print2DArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            System.Console.Write(array[i, j] + " ");
        }
    System.Console.WriteLine();
    }
}

double[] averageNumbers = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++) 
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++) 
        {
           result += array[j, i];
        }
        averageNumbers[i] = result / array.GetLength(0);
    }
    System.Console.WriteLine();

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Create2DArray(array);
Print2DArray(array);



