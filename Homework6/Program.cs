// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int[] CreateArray (int size)
// {
//     int[] newarray = new int [size];
//     for(int i = 0; i < size; i++) 
//     {
//         Console.Write($"input number {i}: ");
//         newarray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newarray;
// }

// void PrintArray (int [] array)
// {
//     for(int  i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int CountPos (int [] array)
// {
//     int count = 0;
//     for(int  i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)  count++;

//     }
//     return count;
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size);
// PrintArray(array);
// Console.Write($"Count of numbers > 0: {CountPos (array)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// void PointPeresech(double k1, double b1, double k2, double b2)
// {
   
      
// }

// Console.WriteLine("input k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());

//     double x= (b2-b1)/(k1-k2);
//     double y= k1*x+b1;

// Console.WriteLine($"   x ->  {x};  y->   {y}  ");