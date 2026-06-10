//Задание 3
//Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры.

//Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578. (С помощью арифметических операторов)


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());

Console.WriteLine(num1 * 1000 + num2 * 100 + num3 * 10 + num4 * 1);