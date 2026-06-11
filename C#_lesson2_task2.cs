//Задание 2
//Пользователь вводит с клавиатуры два числа. Первое число — это значение, 
//второе число процент, который необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10. 
//Требуется вывести на экран 10 процентов от 90. Результат: 9.

double value = double.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());
Console.WriteLine(value * percentage/100);
