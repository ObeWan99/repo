////////////////////////////////////////////////////// Задача 21

/*
Console.Clear();
Console.WriteLine("Введите 2 координаты");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());
double e = double.Parse(Console.ReadLine());
double f = double.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(a-b, 2) + Math.Pow(c - d, 2)+Math.Pow(e-f, 2));
Console.WriteLine($"{s}");
*/
  
///////////////////////////////////////////////////// Задача 23

/*
Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Получи");
for(int i = 1; i <= n; i++)
{
arr[i-1]=i*i*i;
}
for(int i =0; i<n; i++)
Console.WriteLine($"{arr[i]}");
*/

//////////////////////////////////////// Палиндром

/*
int num, rem, sum = 0, temp;
  
        Console.Write("Enter a number:");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
                       
        }
        if (temp == sum) //checking whether the reversed number is equal to entered number
        {
            Console.WriteLine("Number is Palindrome");
        }
        else
        {
            Console.WriteLine("Number is not a palindrome");
        }
        Console.ReadLine();
        */

       
       /*
        Console.Clear();
        Console.WriteLine($"{mas()}");
        int[] mas()
        {
            Console.WriteLine("Введите размер массива");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
           for(int i = 0; i < size; i++)
           {
                 arr[i] = new Random().Next(0, 2);
                 Console.WriteLine($"{arr[i]}");
           }
           return arr;
        }
        */



//////////////////////////////////////////////// Задача 25

/*
    int Rer(int a, int b)
    {

        int otv = 1;
        for(int i = 1; i <= b; i++)
        {
            otv = otv * a;
        }
        return otv;
    }

bool Prover(int ch1)
{
    if(ch1 < 0)
    {
        Console.WriteLine("показатель не должен быть меньше 0");
         return false;
    }
    return true;
}

    Console.Clear();
    Console.WriteLine("Введите два числа");
    int ch = int.Parse(Console.ReadLine());
    int ch1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"{Prover(ch1)}");
    Console.WriteLine($"{Rer(ch, ch1)}"); 
    */

    /////////////////////////////////////////////// Задача 27

    /*
    int Otv(int ch)
    {
        int a = 0;
        while(ch > 0){
        a = a + ch % 10;
        ch = ch / 10;
        }

        return a;
    }

    Console.Clear();
    Console.WriteLine("Введите число");
    int ch = int.Parse(Console.ReadLine());
    Console.WriteLine($"{Otv(ch)}");
    */

    ////////////////////////////////////////// Задача 29



/*
   int Mass1 (int[] arr)
   {
    int count=0;
    foreach(int el in arr)
    {
       if(el > 10 && el <99){
        
        count++;
       }       
       
    }
    return count;
   }*/

///////////////////////////////////////////////////////////// Задача 34
/*
 int Mass1 (int[] arr)
    {
        int count=0;
        for(int i = 0; i < arr.Length-1; i++)
        { 
            if(arr[i]%2==0)
            {
                count++;
            }
           
        }
        return count;
    }
    



    int[] Mass (int size, int ch, int ch1)
    {
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        { 
            arr[i] = new Random().Next(ch,ch1);
        }
        return arr;
    }
    
    int Vvod(string message)
    {
        Console.WriteLine(message);
        string dlina = Console.ReadLine();
        int a = int.Parse(dlina);
        return a;
    }

    void Print(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
        Console.WriteLine($" вывод {arr[i]}");
        }

    }

    Console.Clear();
    
    int size = Vvod("Длина массива");
    int ch = Vvod("начальный диапазон");
    int ch1 = Vvod("конченый диапазон");
    int[] arr = Mass(size, ch, ch1);
    Mass1 (arr);
    Console.WriteLine($"{Mass1(arr)}");
*/


    ///////////////////////////////////////////////////// Задача 36
    /*
    Console.Clear();

    int Vvod (string lengh)
    {
        Console.WriteLine(lengh);
        string dlina = Console.ReadLine();
        int a = int.Parse(dlina);
        return a;
    }

    int[] Mass (int size, int ch, int ch1)
    {
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        { 
            arr[i] = new Random().Next(ch,ch1);
        }
        return arr;
    }

    int Mass1 (int[] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i+=2)
        { 
                sum += arr[i];
        }
        return sum;
    }
    
    void Print(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
        Console.WriteLine($" вывод {arr[i]}");
        }

    }

    int size = Vvod("Длина массива");
    int ch = Vvod("начальный диапазон");
    int ch1 = Vvod("конченый диапазон");
    int[] arr = Mass(size, ch, ch1);
    Print(arr);
    Mass1(arr);
    Console.WriteLine($"{Mass1(arr)}");
    */


    ////////////////////////////// Задача 38

  Console.Clear();

    int Vvod (string lengh)
    {
        Console.WriteLine(lengh);
        string dlina = Console.ReadLine();
        int a = int.Parse(dlina);
        return a;
    }

    int[] Mass (int size, int ch, int ch1)
    {
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        { 
            arr[i] = new Random().Next(ch,ch1);
        }
        return arr;
    }

    // void Mass1 (int[] arr,int min, int max)
    // {
        
    //     for(int i = 0; i < arr.Length; i++)
    //     { 
           
    //             if(max<arr[i+1])
    //             {
    //                 max=arr[i+1];
    //             }
    //             else if(min > arr[i+1])
    //             {
    //                 min = arr[i+1];
    //             }
    //     }
    //    Console.WriteLine($"{max}и {min}");
    // }
  

    void Print(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

    int size = Vvod("Длина массива");
    int ch = Vvod("начальный диапазон");
    int ch1 = Vvod("конченый диапазон");
    int[] arr = Mass(size, ch, ch1);

    Print(arr);
    //Mass1(arr,ch,ch1);
    
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int z = 0; z < arr.Length; z++)
{
    if (arr[z] > max)
        {
            max = arr[z];
        }
    if (arr[z] < min)
        {
            min = arr[z];
        }
}
Console.WriteLine($"всего {arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");