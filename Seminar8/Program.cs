/////////////////////////////////////////////// Задача 54
// using System;
// using static System.Console;
// Clear();


// int Vvod(string fraza)
// {
//     WriteLine(fraza);
//     string a = ReadLine();
//     int b = int.Parse(a);
//     return b;
// }

// int[,] GetArray(int rows, int cols)
//  {
//     int[,] mas = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             mas[i,j] = new Random().Next(0,10);
//         }
//     }
//     return mas;
//  }

// void ChArray(int[,] mas)
//  {
    
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             for (int k = 0; k < mas.GetLength(1) - 1; k++)
//             {
//                 if (mas[i, k] < mas[i, k + 1])
//                 {
//                     int temp = mas[i, k + 1];
//                     mas[i, k + 1] = mas[i, k];
//                    mas[i, k] = temp;
//                 }
//             }
//         }
    
//     }
//  }


//  void PrintArray(int[,] mas)
//  {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]}\t");
//         }
//         WriteLine();
//     }
//  }




// int rows = Vvod("Введите кол-во строк");
// int cols = Vvod("Введите кол-во столбиков");
// int[,] array = GetArray(rows,cols);
// PrintArray(array);
// WriteLine("");
// ChArray(array);
// PrintArray(array);

/////////////////////////////////////////////// Задача 56

// using System;
// using static System.Console;
// Clear();


// int Vvod(string fraza)
// {
//     WriteLine(fraza);
//     string a = ReadLine();
//     int b = int.Parse(a);
//     return b;
// }

// int[,] GetArray(int rows, int cols)
//  {
//     int[,] mas = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             mas[i,j] = new Random().Next(0,10);
//         }
//     }
//     return mas;
//  }


// void ChArray(int[,] mas)
//  {
//     int minRow = 0;
//     int sumRow = 0;
//     int minSumRow = 0;

//     for(int i = 0; i < mas.GetLength(1); i++) // определяем сумму первой строки массива для дальнейшего сравнения 
//     {
//         minRow+=mas[0,i];
//     }

//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             sumRow +=mas[i,j];
//             if(minRow > sumRow)
//             {
//                 minRow = sumRow;
//                minSumRow = i;
//             }
//             sumRow=0;
//         }
    
//     }
//     Write($"{minSumRow + 1 } строка");
//  }

//  void PrintArray(int[,] mas)
//  {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]}\t");
//         }
//         WriteLine();
//     }
//  }




// int rows = Vvod("Введите кол-во строк");
// int cols = Vvod("Введите кол-во столбиков");
// int[,] array = GetArray(rows,cols);
// PrintArray(array);
// WriteLine("");
// ChArray(array);



/////////////////////////////////////////////// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// using System;
// using static System.Console;
// Clear();



// int rows = Vvod("Введите кол-во строк 1-ой");
// int cols = Vvod("Введите кол-во столбиков 1-ой, и кол-во строк 2 матрицы");
// int row = Vvod("Введите кол-во столбцов 2 матрицы");
// int range = Vvod("Введите диапазон случайных чисел: от 1 до ");

// int[,] array = new int[rows,cols];
// GetArray(array);
// PrintArray(array);

// WriteLine("");

// int[,] array1 = new int[cols,row];
// GetArray(array1);
// PrintArray(array1);

// int[,] res = new int [rows,row];

// ChArray(array, array1, res);
// WriteLine("Полученная матрица");
// PrintArray(res);



// int Vvod(string fraza)
// {
//     WriteLine(fraza);
//     string a = ReadLine();
//     int b = int.Parse(a);
//     return b;
// }

// void GetArray(int[,] mas)
//  {
  
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             mas[i,j] = new Random().Next(range);
//         }
//     }
   
//  }

// void ChArray(int[,] mas, int[,] mas1, int[,] res)
//  {
    
//     for(int i = 0; i < res.GetLength(0); i ++)
//     {
//         for(int j = 0; j< res.GetLength(1); j ++)
//         {
//             int sum=0;
//             for(int k = 0; k < mas.GetLength(1); k++)
//             {
//                 sum += mas[i,k] * mas1[k, j];
//             }
//                 res[i,j] = sum;
//         }
//     }

//  }

//  void PrintArray(int[,] mas)
//  {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]}\t");
//         }
//         WriteLine();
//     }
//  }



/////////////////////////////////////////////// Задача 60


// using System;
// using static System.Console;
// Clear();

// WriteLine($"Введите размер массива X x Y x Z: ");
// int x = Vvod("Введите X: ");
// int y = Vvod("Введите Y: ");
// int z = Vvod("Введите Z: ");
// WriteLine("");


// int[,,] array = new int[x,y,z];
// GetArray(array);
// PrintArray(array);


// int Vvod(string fraza)
// {
//     WriteLine(fraza);
//     string a = ReadLine();
//     int b = int.Parse(a);
//     return b;
// }

// void PrintArray (int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Write( $"Z({k})={array[i,j,k]}; ");
//       }
//       WriteLine();
//     }
//     WriteLine();
//   }
// }

// void GetArray(int[,,] array)
// {
//   int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array.GetLength(0); x++)
//   {
//     for (int y = 0; y < array.GetLength(1); y++)
//     {
//       for (int z = 0; z < array.GetLength(2); z++)
//       {
//         array[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }


/////////////////////////////////////// Задача 62
/*

ТУТ СЛЕГКА ТЯЖКО ЧЕТ


*/