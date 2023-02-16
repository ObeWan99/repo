/*Console.Clear();
void FillArray(int[] massiv)
{
    int n = massiv.Length;
    for(int i = 0; i < n; i ++)
    {
        massiv[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int size = col.Length;
     for(int i = 0; i < size; i ++)
    {
       Console.WriteLine(col[i]);
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
*/

/*Console.Clear();
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write($"{arr[i]}");
}
Console.WriteLine("");
Console.WriteLine("переворачиваем");

for(int i = 0; i < 10; i++)
{
    if(arr[i]==0)
    {
        arr[i]=1;
    }
    Console.Write($"{arr[i]}");
}
*/



//////////////////////////////////                  Задача 10

/*

Console.Clear();
int n = new Random().Next(100, 999);
Console.WriteLine($"{n}-> {n/10%10}");


*/


///////////////////////////////////                   Задача 13

/*
Console.Clear();
int n = new Random().Next(10, 200);
Console.WriteLine($"{n}");
if(100 <= n && n <= 999) Console.WriteLine($"{n%10}");
else Console.WriteLine($"{n}-> 3 цифры нет ");
*/

///////////////////////////////////                   Задача 15


Console.Clear();
int n = new Random().Next(1, 8);
Console.WriteLine($"{n}");
if(n == 6 || n == 7) Console.WriteLine($"{n} -выходной день");
else Console.WriteLine($"{n} -работаем, братья");