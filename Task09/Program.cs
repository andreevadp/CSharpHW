// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число ");
int Number = int.Parse(Console.ReadLine());

int a = Number / 100;
int b = Number % 10;

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Число без второй цифры: " + a + b);