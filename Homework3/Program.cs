// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// РЕШЕНИЕ

// void Pilindrom (int num)
// {
// int FirstDigit = num / 10000; 

// int FindSecondDigit = num / 1000;
// int SecondDigit = FindSecondDigit % 10;

// int FindFourthDigit = num % 100;
// int FourthDigit = FindFourthDigit / 10;

// int FifthDigit = num % 10;

//     if (FirstDigit == FifthDigit && SecondDigit == FourthDigit ) Console.WriteLine($"{num} -> да");
//     else Console.WriteLine($"{num} -> нет");   
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Pilindrom(num);



// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// РЕШЕНИЕ

// double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
// }

// Console.WriteLine("input coordinate x1:");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate y1:");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate x2:");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate y2:");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate z2:");
// double z2 = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {FindDistance(x1,y1,z1,x2,y2,z2)}");



// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// РЕШЕНИЕ

// void QuadDigits(int N)
// {
// int count = 1;
// while (count <= N )
// {
//     Console.Write($"{Math.Pow(count, 3)}, ");
//     count++;
// }
// }


// Console.WriteLine("Input N:");
// int N = Convert.ToInt32(Console.ReadLine());
// QuadDigits(N);







