//Задание 1
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. 
//    Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz. 
//    Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
//Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.


Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

if (number < 1 || number > 100)
{
    Console.WriteLine("Error: out of range 1 - 100");
}
else
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (number % 3 != 0 && number % 5 != 0)
    {
        Console.WriteLine(number);
    }
}

