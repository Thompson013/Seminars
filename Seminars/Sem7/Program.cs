//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
    }
}

void Print2DArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++) // array.GetLength(0) == колчество строк в 2Д массиве
    {
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(0) == количество столбцов в 2Д массиве
        {
            System.Console.Write(array[i, j] + " ");
        }
    System.Console.WriteLine();
    }
}

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
    {
        System.Console.WriteLine("Entered lines are out of massive");
        return array;
    }
    else
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    return array;
}

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter amaximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number of row1 to change: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number of row2 to change: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
Print2DArray(ChangeRows(myArray, row1, row2));