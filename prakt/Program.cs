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
    Console.Clear();
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine($"{Mass(size)}");

    int[] Mass (int size)
    {
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(0,100);
            Console.WriteLine($" вывод {arr[i]}");
        }
        return arr;
    }
    */

    