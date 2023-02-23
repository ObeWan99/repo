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