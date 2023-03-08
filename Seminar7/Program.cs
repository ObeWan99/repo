// using System;
// using static System.Console;
// Clear();

// int[,] GetArray(int n, int m , int minValue, int maxValue)
// {
//     int [,] res = new int[n,m];
//     for(int i = 0; i < res.GetLength(0); i++)
//     {
//         for(int j = 0; j < res.GetLength(1); j++)
//         {
//             res[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return res;
// }

// void PrintArray(int [,] mas)
// {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]} ");
//         }
//         WriteLine();
//     }
// }

// Write("Введите кол-во строк ");
// int rows = int.Parse(ReadLine());
// Write("Введите кол-во столбцов ");
// int cols = int.Parse(ReadLine());
// int [,] array = GetArray(rows,cols,0,10);
// PrintArray(array);







// using System;
// using static System.Console;
// Clear();

// int[,] GetArray(int n, int m )
// {
//     int [,] res = new int[n,m];
//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//            res[i,j] = i+j;
            
//         }
//     }
//     return res;
// }

// void PrintArray(int [,] mas)
// {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]} ");
//         }
//         WriteLine();
//     }
// }

// Write("Введите кол-во строк ");
// int rows = int.Parse(ReadLine());
// Write("Введите кол-во столбцов ");
// int cols = int.Parse(ReadLine());
// int [,] array = GetArray(rows,cols);
// PrintArray(array);




// using System;
// using static System.Console;
// Clear();

// int GetArray1(int[,] massiv )
// {
//     int a = 0;
//     for(int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for(int j = 0; j < massiv.GetLength(1); j++)
//         {
//             if(i==j){
//                 a+=massiv[i,j];

//             }
            
//         }
//     }
//    // WriteLine($"{a}");
//     return a;
// }

// int[,] GetArray(int n, int m )
// {
//     int [,] res = new int[n,m];
//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//            res[i,j] = new Random().Next(0, 11);
            
//         }
//     }
//     return res;
// }

// void PrintArray(int [,] mas)
// {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]} ");
//         }
//         WriteLine();
//     }
// }

// Write("Введите кол-во строк ");
// int rows = int.Parse(ReadLine());
// Write("Введите кол-во столбцов ");
// int cols = int.Parse(ReadLine());
// int [,] array = GetArray(rows,cols);
// PrintArray(array);
// WriteLine();
// WriteLine(GetArray1(array));


//////////////////////////////////// Задача 47

// using System;
// using static System.Console;
// Clear();


// void PrintArray(double [,] mas)
// {
//     for(int i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write("{0,6:F2}", mas[i, j]);
//         }
//         WriteLine();
//     }
// }



// double[,] GetArray()
// {
//     double [,] res = new double[3,4];
//     for(int i = 0; i < 3; i++)
//     {
//         for(int j = 0; j < 4; j++)
//         {
//            res[i,j] = new Random().NextDouble()*100;
           
            
//         }
//     }
//     return res;
// }

// double [,] array = GetArray();
// PrintArray(array);


//////////////////////////////////// Задача 50

// using System;
// using static System.Console;
// Clear();



// int Vvod(string name)
// {
//     WriteLine(name);
//     string ch = ReadLine();
//     int a  = int.Parse(ch);
//     return a;
// }

// int[,] GetArray()
// {
//     int[,] mas = new int[6,10];
//     for(int  i = 0; i < 6; i++)
//     {
//         for(int j = 0; j < 10; j++)
//         {
//             mas[i,j] = new Random().Next(0,10);
//         }
//     }
//     return mas;
// }

// void PrintArray(int[,] mas)
// {
//      for(int  i = 0; i < mas.GetLength(0); i++)
//     {
//         for(int j = 0; j < mas.GetLength(1); j++)
//         {
//             Write($"{mas[i,j]}\t");
//         }
//         WriteLine();
//     }
// }

// void GetElem(int [,] mas, int a, int b)
// {   
//     if(a < mas.GetLength(0) && b < mas.GetLength(1))
//     WriteLine($"{mas[a,b]}");
//     else{
//         WriteLine($"{a}{b}->такого числа нет");
//     }

// }

// int rows = Vvod("Введите  строкy");
// int cols = Vvod("Введите столбец");
// int [,] array = GetArray();
// PrintArray(array);
// GetElem(array, rows, cols);

//////////////////////////////////// Задача 52
using System;
using static System.Console;
Clear();

int Vvod(string fraza)
{
    WriteLine(fraza);
    string a = ReadLine();
    int b = int.Parse(a);
    return b;
}
 int[,] GetArray(int rows, int cols)
 {
    int[,] mas = new int[rows,cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            mas[i,j] = new Random().Next(0,10);
        }
    }
    return mas;
 }

 void PrintArray(int[,] mas)
 {
    for(int i = 0; i < mas.GetLength(0); i++)
    {
        for(int j = 0; j < mas.GetLength(1); j++)
        {
            Write($"{mas[i,j]}\t");
        }
        WriteLine();
    }
 }

 void SredMas(int[,] mas)
 {
    
    for(int j = 0; j < mas.GetLength(1); j++)
    {
        double a = 0;
        for(int i = 0; i < mas.GetLength(0); i++)
        {
            a +=mas[i,j];
        }
        // a = a + mas[i,0];
        // b += mas[i,1];
        // c += mas[i,2];
         WriteLine($"{a / mas.GetLength(0)}");
    }
    //a = a / mas.GetLength(1);
    // b = b / mas.GetLength(1);
    // c = c / mas.GetLength(1);
    // WriteLine($"{a} {b} {c} ");
    
 }


int rows = Vvod("Введите кол-во строк");
int cols = Vvod("Введите кол-во столбиков");
int[,] array = GetArray(rows,cols);
PrintArray(array);
SredMas(array);
