// Найти максимальное из трех чисел

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("Максимальное число: " + a);
}
else if (b>c) 
{
    Console.WriteLine("Максимальное число: " + b); 
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}