// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Create3DigitArray(int number)
{
    int[] array = new int[number];
        for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int FindEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        System.Console.Write(number[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Enter a quantity of array number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = Create3DigitArray();
PrintArray(array);
