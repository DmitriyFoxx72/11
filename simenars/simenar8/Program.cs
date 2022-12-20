
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
// {                                                                           
//   int[,] newArray = new int[rows, columns];  

//   for (int i = 0; i < rows; i++)
//   {
//      for(int j = 0; j < columns; j++)
//      {
//        newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//      }
//   }
//   return newArray;    
// }
// void ShowArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }
// void OrderArrayLines(int[,] array)
// {  
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// } 
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2DArray(rows, columns, min, max);

// ShowArray(myArray);
// Console.WriteLine($"\nЭлементы строк вмассиве расположены в порядке убывани: ");
// OrderArrayLines(myArray);
//  ShowArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
//  суммой элементов: 1 строка


// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
// {                                                                           
//   int[,] newArray = new int[rows, columns];  

//   for (int i = 0; i < rows; i++)
//   {
//      for(int j = 0; j < columns; j++)
//      {
//        newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//      }
//   }
//   return newArray;    
// }
// void ShowArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }
// int ShowMinSumRow (int[,] array)
// {     
//          int result = 0;
//          int minsum1 = 0;
// for (int k = 0; k < array.GetLength(1); k++)
// {
//     minsum1 += array[0,k];
// }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {  
//          int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         { 
         
//             sum += array[i,j];
//         }  
//             if(minsum1 >  sum)
//             {
//                 minsum1 = sum;
//                 result = i;
//             }
//         }     
//    return result;
// } 
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2DArray(rows, columns, min, max);
// ShowArray(myArray);
// ShowMinSumRow(myArray);
//   Console.WriteLine($" Индекс строки с минимальной суммой в строке -> { ShowMinSumRow (myArray) }");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MultiplyMatrices(int[,] arrA, int[,] arrB)
{
    int[,] zeroMatrix = new int[1, 1] {{ 0 }};
    if (arrA.GetLength(1) != arrB.GetLength(0))  
    {
        Console.WriteLine("Произведение матриц не возможно");
        return zeroMatrix;
    }
    else
    {
        int m = arrA.GetLength(0);
        int n = arrA.GetLength(1);
        int p = arrB.GetLength(1);
        int[,] arrResult = new int[m, p];//
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    arrResult[i,j] = arrResult[i,j] + arrA[i,k] * arrB[k,j];
                }
            }
        }
        return arrResult;
    }
}
// int[,] arrayA = new int[2, 4] { { 1, 2, 3,7 }, { 4, 5, 6,7} };
// int[,] arrayB = new int[3, 2] { { 10, 11 }, { 20, 21 }, { 30, 31 } };
int[,] arrayA = new int[4, 5]  {{2,4,5,6,7,}, {3,2,8,9,9,},{2,4,1,2,3}, {3,2,4,5,6}};
int[,] arrayB = new int[5, 4]  {{2,4,5,6,}, {3,2,8,9},{2,4,1,2}, {3,2,4,5},{3,2,8,9}};
Console.WriteLine("Matrix A");
Show2DArray(arrayA);
Console.WriteLine("Matrix B");
Show2DArray(arrayB);
int[,] arrayResult = MultiplyMatrices(arrayA, arrayB);
Console.WriteLine("Matrix sum");
Show2DArray(arrayResult);


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
//программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

























