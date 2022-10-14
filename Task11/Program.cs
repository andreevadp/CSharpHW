// Найти третью цифру числа или сообщить, что её нет
//Console.WriteLine("Введите число от 0 до 999");
//int Number = int.Parse(Console.ReadLine());

//if (Number / 100 == 0)
//{
//    Console.WriteLine("Заданное число: "+ Number);
//    Console.WriteLine("Третьей цифры в числе нет");
//}
//else
//{
//    Console.WriteLine("Заданное число: "+ Number);
//    Console.WriteLine("Третья цифра: " + Number % 10);
//}
// Код не выполняет свою функцию, если, не взирая на условия, вводить четырех- или более- значные числа
// В обход этому можно не давать вводить пользователю число самостоятельно, а ввести условие
//int Number = new Random().Next(0, 999); или строже (10,200) и тп.
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

if (Number < 100)
    Console.WriteLine("Третьей цифры в числе нет");
else
{
    while (Number > 1000)
        Number /= 10;
    Console.WriteLine($"Третья цифра: {Number%10}");    
}    