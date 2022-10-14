// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите заданное число ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите делитель ");
int divider = int.Parse(Console.ReadLine());

int remains = Number % divider; // остаток от деления

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Делитель: " + divider);

if (Number % divider == 0)
{
    Console.WriteLine("Число " + Number + " кратно числу " + divider);
}
else
{
    Console.WriteLine("Число " + Number + " не кратно числу " + divider);
    Console.WriteLine("Остаток от деления: " + remains);
}
if (Number < divider)
{
    Console.WriteLine("Так делить нельзя! (ошибка)");
}