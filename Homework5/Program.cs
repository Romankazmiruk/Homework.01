// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



// [345, 897, 568, 234] -> 2

// int[] RandomArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(99,999);
//    }
//    return array;

// }

// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Input Size Array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];


// int Kol(int[] Array)
// {
// int kol = 0;
// for (int i = 0; i < Array.Length; i++)
// {
// if (Array[i] % 2 == 0)
// kol = kol + 1;
// }
// return kol;
// }

// array = RandomArray(array);
// Kol(array);
// PrintArray(array);
// Console.Write($"количество чётных чисел в массиве: {Kol(array)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




// int[] RandomArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(99,999);
//    }
//    return array;

// }

// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Input Size Array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];


// int Kol(int[] array)
// {
// int sum = 0;
// int i = 0;
// while (i < array.Length)
// {
// sum = sum + array[i];
// i = i + 2;
// }
// return sum;
// }

// array = RandomArray(array);
// Kol(array);
// PrintArray(array);
// Console.Write($"сумма элементов, стоящих на нечётных позициях: {Kol(array)}");





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] RandomArray(double[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().NextDouble();
//    }
//    return array;

// }

// void PrintArray(double[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// double Raznost(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
//     while (i < randomArray.Length)
//     {
//         if (max<randomArray[i])
//         max = randomArray[i];
//         if (min>randomArray[i])
//         min = randomArray[i];
//         i = i + 1;
//     }
// return max-min;
// }

// Console.WriteLine("Input Size Array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];


// array = RandomArray(array);
// Raznost(array);
// PrintArray(array);
// Console.Write($"разница между максимальным и минимальным элементов массива: {Raznost(array)}");