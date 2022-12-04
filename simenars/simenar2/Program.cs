

// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int CutNumber (int num)
// {
//         int ed = num % 100;
//         int sot= ed / 10;
//         return sot;
// }
// Console.WriteLine( "Input num ");
// int a = Convert.ToInt32(Console.ReadLine( ));
// int N = CutNumber(a);
// Console.WriteLine($"New version of  is {N}"); 


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



/*
 int CutNumber(int num)
        {    
           int  num1 = num;
            if(num1 > 99)
                {while(num1 > 1000) 
                   {  
                    num1 = num1 / 10;
                    }
                  return num1 = (num1 % 10)  %10;
                 }
                return -1;     
         }  
        Console.WriteLine("Input num ");
         int num = Convert.ToInt32(Console.ReadLine());

     int N = CutNumber(num);
       
        if(N == -1)
            {
            Console.WriteLine($"{num} -> Не содержит третьего числа");
        }
        else
        {
              Console.WriteLine($"{num} -> Третья цифра заданного числа {N}");
        }
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*

bool main (int num1)
{
    if(num1 == 6 || num1 == 7)
    {
    return true;
    }			
    else
    {
    return false;
    }   
}
Console.WriteLine("Input nambe ");
int num1 = Convert.ToInt32(Console.ReadLine());
bool N = main(num1);
Console.WriteLine($"{N} ");
*/


