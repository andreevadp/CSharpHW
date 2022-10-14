// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число: ");
string Number = Console.ReadLine();
if (Number.Length < 3)
    Console.WriteLine("Третьей цифры в числе нет");
else
{
    Console.WriteLine($"Третья цифра: {Number[2]}");    
}    
