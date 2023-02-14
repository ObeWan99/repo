/*Console.Clear();
Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if(a*a == b)
{
    Console.WriteLine("квадрат числа а раверн числу b");
}
else
{
    Console.WriteLine("квадрат числа а не равен числу b");
}
*/

Console.Clear();
Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
if(a==1){Console.WriteLine($"{a} пн");}
else if(a==2){Console.WriteLine($"{a} вт");}
else if(a==3){Console.WriteLine($"{a} ср");}
else if(a==4){Console.WriteLine($"{a} чт");}
else if(a==5){Console.WriteLine($"{a} пт");}
else if(a==6){Console.WriteLine($"{a} сб");}
else if(a==7){Console.WriteLine($"{a} вс");}
else{Console.WriteLine($"{a}нет такого дня недели");}