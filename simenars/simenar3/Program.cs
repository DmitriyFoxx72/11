

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int Palindrome (int num)
// {
//     int num1 = 0;
//     int num2 = 0;
//     int num3 =0;
//     int num4 = 0;

//     num1 = (num % 100000)  / 10000;
//     num2 = (num % 10000)  / 1000;    
//     num3 = (num % 100)  / 10;
//     num4 = (num % 10);

//             if (num1 == num4 || num2 == num3)
//                {            
//                 return num3;
//                }
//             return -1;
// }

// Console.WriteLine("Input num ");
// int num = Convert.ToInt32(Console.ReadLine());
// int N = Palindrome(num);     
// if(N == -1)
// {
//  Console.WriteLine($"Ваше число: {num} -> не палиндром");
//   }
//    else
//  {
//    Console.WriteLine($"Ваше число: {num} -> палиндром");
//  }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double GetLens(int x1,int y1,int z1,int x2,int y2,int z2)
// {
//     double len = Math.Round (Math.Sqrt((x1 - x2) * (x1 -x2)  + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 -z2)),2);
//     return len;
// }
// Console.WriteLine(GetLens(3,6,8,2,1,-7));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void SqrO1(int N)
// {
//        for (int i = 1; i <= N; i++)
//        {
//              Console.WriteLine($"{i} -> {i * i * i}");
//        }
// }

// Console.WriteLine("Введите число N = ");
// int N = Convert.ToInt32(Console.ReadLine());
// SqrO1(N);






