// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumbers (int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write(n+ " ");
//         ShowNumbers(n-1);
//     }
// }
// ShowNumbers(10);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumOfNumbers (int m, int n, int sum)
// {
//     if (m > n) 
//     {
//         Console.WriteLine(sum); 
//         return;
//     }
//     sum = sum + (m++);
//     SumOfNumbers(m, n, sum);
// }

// int n = 1;
// int m = 10;
// int sum = 0;
// SumOfNumbers(n, m, sum);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AckermanFunc(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunc(m - 1, 1);
  else return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}


int n = 2;
int m = 3;
Console.Write(AckermanFunc(m, n));
