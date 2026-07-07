//Задание 6
//Пользователь вводит с клавиатуры два числа.     
//Нужно показать все четные числа в указанном диапазоне.
//Если границы диапазона указаны неправильно требуется произвести нормализацию границ.
//Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.


Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());


Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();

if  (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}


for (int i = num1; i <= num2; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Even number from range is: {i}");
    }
}
