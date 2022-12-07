
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 

// int [] CreatArray (int size) 
// {
//     int [] newArray = new int [size]; 
//     for (int i = 0; i < size; i++)
//     {
//     Console.WriteLine($"Введите элемент {i}");
//     newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;   
// }
// void ShowArray (int [] arr) 
// {
//     Console.Write("Массив -> ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+ " ");
//     }
//     Console.WriteLine();
// }
// void FindCount(int []array)
// {
//     int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во элементов > 0: {count}");
// }
// Console.WriteLine("Input size ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] MyArray = CreatArray(size);
// ShowArray(MyArray);
// FindCount(MyArray);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
int k1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 =  Convert.ToInt32(Console.ReadLine());
  
int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");


