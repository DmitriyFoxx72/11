// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


//  int[] CreateRandomArray (int size, int minValue, int maxValue)
//  {
//     int [] newArray  = new int [size];
//     for(int i=0; i < size; i++)


//     {
//      newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
//  }
//   void ShowArray (int[] array)
//   {
//      Console.Write("Получившийся массив ->");
//      for(int i=0; i < array.Length; i++)
//      {
//          Console.Write(array[i] + " ");
//      }
//     // Console.WriteLine();
//   }

//  void NumEven (int[] array)
//  {
 
//      int count = 0;
//      for (int i=0; i < array.Length; i++)
//      {
//      if (array[i] % 2 == 0)
//         count++;
//      }
//      Console.WriteLine($" Количество чётных чисел в массиве.-> {count} ");
//  }
//  Console.WriteLine("Введите размер массива");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите минимальное значение элемента");
//  int min = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите максимальное значение элемента");
//  int max = Convert.ToInt32(Console.ReadLine());
//  int[] myArray = CreateRandomArray(a,min,max);
//  ShowArray(myArray);
//   NumEven(myArray);





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//   int[] CreateRandomArray (int size, int minValue, int maxValue)
//  {
//     int [] newArray  = new int [size];
//     for(int i=0; i < size; i++)
//     {
//      newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
//  }
//   void ShowArray (int[] array)
//   {
//      Console.Write("Получившийся массив ->");
//      for(int i=0; i < array.Length; i++)
//      {
//          Console.Write(array[i] + " ");
//      }
//     // Console.WriteLine();
//   }

//  void SumOdd (int[] array)
//  {
//      int sumElem = 0;
//          for(int i=1; i < array.Length; i+=2)
//      {
//        sumElem = sumElem + array[i];
//      }
//      Console.WriteLine($" Сумма элементов на нечётных позициях в массиве равна -> {sumElem}");
//  }
//  Console.WriteLine("Введите размер массива");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите минимальное значение элемента");
//  int min = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите максимальное значение элемента");
//  int max = Convert.ToInt32(Console.ReadLine());
//  int[] myArray = CreateRandomArray(a,min,max);
//  ShowArray(myArray);
// SumOdd(myArray);


// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    Random rand = new Random();
    for(int i = 0;  i < size; i++)
    {
            newArray[i] = Math.Round(minValue +  rand.NextDouble() * (maxValue - minValue),2);
    }
    return newArray;
}
   void ShowArray (double[] array)
   {
      Console.Write("Получившийся массив ->");
      for(int i=0; i < array.Length; i++)
      {
          Console.Write(array[i] + " ");
      }
     // Console.WriteLine();
   }

  void DiffMaxMin (double[] array)
  {
     double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
            if (array[i] > max)
              max = array[i];
             if (array[i] < min) 
                min = array[i];
    }
      result = Math.Round((max - min), 2);  
      Console.WriteLine($" Разница между максимальным и минимальным значением в массиве равна -> {result}");
  }
  Console.WriteLine("Введите размер массива");
  int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите минимальное значение элемента");
  int min = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите максимальное значение элемента");
  int max = Convert.ToInt32(Console.ReadLine());
  double[] myArray = CreateRandomArray(a,min,max);
  ShowArray(myArray);
 DiffMaxMin(myArray);
