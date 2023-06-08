// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int [,] Create2DRandomArray (int rows, int colums, int MinValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(MinValue, maxValue);
//         }
//     }
//     return array;

// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 Console.Write(array[i,j]+" ");
//             }
//             Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// int [,] SortArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//                 for (int t = 0; t < array.GetLength(1)-1; t++)
//             if  (array[i,t] < array[i,t+1])
//             {
//                 int temp = array[i,t];
//                 array[i,t] = array[i,t+1];
//                 array[i,t+1] = temp;
//             }
//         }
//     }
//     return array;
// }


// Console.WriteLine("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] myArray = Create2DRandomArray(rows,colums,min,max);
// Print2DArray (myArray);
// SortArray(myArray);
// Print2DArray (myArray);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




// int [,] Create2DRandomArray (int rows, int colums, int MinValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(MinValue, maxValue);
//         }
//     }
//     return array;

// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 Console.Write(array[i,j]+" ");
//             }
//             Console.WriteLine();

//     }
//     Console.WriteLine();
// }





// void MinSumRow(int[,] array)
//         {
//             int[] sumrow = new int[array.GetLength(0)];
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     sumrow[i] += array[i, j];
//                 }
//             }
//             int min = 0;
//             for (int i = 0; i < sumrow.Length; i++)
//             {
//                 if (sumrow[min] > sumrow[i]) 
//                 min = i;
//             }
//             Console.Write($"Row of min sum: {min+1}");
//         }



// Console.WriteLine("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] myArray = Create2DRandomArray(rows,colums,min,max);
// Print2DArray (myArray);
// MinSumRow(myArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int [,] Create2DRandomArray (int rows, int colums, int MinValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(MinValue, maxValue);
//         }
//     }
//     return array;

// }


// int [,] Create22DRandomArray (int rows, int colums, int MinValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(MinValue, maxValue);
//         }
//     }
//     return array;

// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 Console.Write(array[i,j]+" ");
//             }
//             Console.WriteLine();

//     }
//     Console.WriteLine();
// }




// void DivMatrix(int[,] array, int[,] array2)
// {
    
//     if (array.GetLength(0) != array2.GetLength(1))
//     {

//     int [,] result = new int[array.GetLength(0), array2.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     { 
//         for (int j = 0; j < array2.GetLength(1); j++) 
//         {
//         for (int k = 0; k < array2.GetLength(0); k++)
//         {
//         result[i,j] += array[i,k] * array2[k,j];
        
//         Console.WriteLine(result);
//         }
        
//         }
        
//     }
    
//     }
    
    
// }

// Console.WriteLine("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] myArray = Create2DRandomArray(rows,colums,min,max);
// int [,] myArray2 = Create22DRandomArray(rows,colums,min,max);
// Print2DArray (myArray);
// Print2DArray (myArray2);
// DivMatrix(myArray,myArray2);
// // Print2DArray(DivMatrix(myArray,myArray2))














// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int [, ,] Create3DRandomArray (int rows, int colums, int glubina, int MinValue, int maxValue)
// {
//     int[, ,] array = new int[rows, colums, glubina];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             for (int k = 0; k < glubina; k++)
//                 {
//                 array[i,j,k] = new Random().Next(MinValue, maxValue);
//                 }
//         }
//     }
//     return array;

// }

// void Print3DArray(int[, ,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 for(int k = 0; k < array.GetLength(2);k++)
//             {
//                 Console.Write($"{array[i,j,k]}{(i,j,k)}");
//             }
//             Console.WriteLine();

//     }
//     }
//     Console.WriteLine();
// }




// Console.WriteLine("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input glubina");
// int glubina = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [, ,] myArray = Create3DRandomArray(rows,colums,glubina,min,max);
// Print3DArray (myArray);








