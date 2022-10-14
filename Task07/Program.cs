// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int Number = int.Parse(Console.ReadLine());

int a = Number / 10;
int b = a % 10;

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Вторая цифра числа: " + b);