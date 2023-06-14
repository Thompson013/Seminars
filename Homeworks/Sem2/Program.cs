// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void Find2ndDigit(int num)
// {
//     if(num >= 100 && num <= 999)
//     {
//         System.Console.WriteLine($"the 2nd digit of the number {num} -> {(num / 10) % 10}");
//     }
//     else
//     {
//         System.Console.WriteLine("This number doesn't contain 3 digit");
//     }  
// }
// System.Console.Write("Enter a 3digit number -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// Find2ndDigit(num);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void Find3rdDigit(int num)
// {
//     int Length = num.ToString().Length;
//     if(Length >= 3)
//     {
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         int result = num % 10;
//         System.Console.WriteLine($"the 3rd digit of the number is " + result);
//     }
//     else
//     {
//         System.Console.WriteLine("This number doesn't contain 3 digit");
//     }  
// }
// System.Console.Write("Enter a number -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// Find3rdDigit(num);

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void FindWeekEnd(int num)
{
    if(num >=1 && num <=7)
    {
        if(num >= 6)
        {
            System.Console.WriteLine("It's a holiday");
        }
        else
        {
            System.Console.WriteLine("it's a working day");
        }
    }    

}

System.Console.Write("Enter a number of a weekday -> ");
int num = Convert.ToInt32(Console.ReadLine());

FindWeekEnd(num);