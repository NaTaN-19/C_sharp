//Задание 5
//Пользователь вводит с клавиатуры показания температуры.
//В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.


Console.Write("Enter temperature: ");
double number = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Choose format: type 1 for Celsius to Fahrenheit, 2 for Fahrenheit to Celsius: ");
int format = int.Parse(Console.ReadLine());
Console.WriteLine();

if (format == 1)
{
    Console.WriteLine(number * 9 / 5 + 32);
}
else if (format == 2)
{
    Console.WriteLine((number - 32) / 1.8);
}
else
{
    Console.WriteLine("Type 1 or 2");
}