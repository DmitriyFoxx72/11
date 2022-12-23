


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



//  int Exponen (int a,int b)
//  {
//         int exp = a;

//      for(int i = 2; i <= b ; i++)
//      {
//          exp = exp * a;
        
//      }
//      return exp;
//  }
//  Console.WriteLine("Input number a");
//  int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number b");
//  int b = Convert.ToInt32(Console.ReadLine());

//  int result = Exponen(a,b);
//  Console.WriteLine(result);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int CutNumber (int num)
// { 
//     int n = num;
//      int sum  = 0;
//      int a = 0;

//       while (n > 0)
//         {
//         a = n - n % 10;
//          sum = sum + (n - a);
//          n = n / 10;
//          }
//          return sum; 
// }

// Console.WriteLine( "Input num ");
// int a = Convert.ToInt32(Console.ReadLine( ));
// int N = CutNumber(a);
// Console.WriteLine($"Сумма цифр в числе {a} равна: {N}"); 



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// void FillArray (int size)
// {
//    int[] array = { 1, 2, 3, 4, 5,56,32,7 };
//     for (int i = 0; i < size; i++)
//     {
//             Console.Write($"{array[i]}  ");
//     }
// }
//  Console.WriteLine("Введите максимальное значение элемента");
//        int a = Convert.ToInt32(Console.ReadLine());
//        FillArray(a);











