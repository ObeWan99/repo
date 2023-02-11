Console.WriteLine("Введите имя пользователя");
string name = Console.ReadLine();
if(name.ToLower() == "маша")
{
    Console.Write("УРАААА это ");
    Console.WriteLine(name);
}
else{
    Console.Write("Я не Маша, я ");
    Console.WriteLine(name);
}