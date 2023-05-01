// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// РЕШЕНИЕ


// int SecondDigit (int Num)
// {
//     int dec = Num / 10;
//     int result = dec % 10;
//     return result;
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = SecondDigit(num);

// Console.Write($"Вторая цифра числа {num} -> {result}");





// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int Get3Digit(int Num)
// {
// // if (Num < 100)  Console.WriteLine($"третьей цифры нет");    
//     while(Num > 999)
//     {
//         Num = Num / 10;
//     }
//     Num = Num %10;
// return Num; 
// }

// bool ValueDigit(int number)
// {
//     if (number < 100)
//         {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//         }
//     return true;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (ValueDigit(num))
// {
//     Console.WriteLine(Get3Digit(num));
// }





// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// РЕШЕНИЕ

// bool WeekEnd(int num)
// {
//     if ((num > 5) && (num <=7)) return true;
//     else return false;
// }
// Console.WriteLine("Input number from 1 to 7:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{WeekEnd(num)}");




