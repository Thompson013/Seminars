// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void FindPalindrom(int num)
// {
//     if(num > 9999 && num < 100000)
//     {
//         if(num / 10000 == num %10 && (num / 1000) % 10 == (num % 100) / 10)
//         {
//             System.Console.WriteLine("the number is palindrom");
//         }
//         else
//         {
//             System.Console.WriteLine("the number isn't palindrom");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Please enter a 5 digit number ");
//     }
// }

// System.Console.WriteLine("Enter a 5 digit number ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindPalindrom(num);

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Find3Distance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// System.Console.WriteLine("Enter X coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter Y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter Z coordinate point A: ");
// double za = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter X coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter Y coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter Z coordinate point B: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B in 3D space {Find3Distance(xa, ya, za, xb, yb, zb)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNumber (int x)
{
    int count = 1;
    while (count <= x)
    {
        System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
        count ++;
    }
}
System.Console.WriteLine("Enter a number ");
int x = Convert.ToInt32(Console.ReadLine());
CubeNumber(x);