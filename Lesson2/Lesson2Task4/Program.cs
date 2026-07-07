//Задание 4
//Пользователь вводит шестизначное число. 

//    После чего пользователь вводит номера разрядов для обмена цифр.

//    Например, если пользователь ввёл один и шесть — это значит,
//    что надо обменять местами первую и шестую цифры.

//Число 723895 должно превратиться в 523897. 

//    (С помощью арифметических операторов)



int sixDigit = int.Parse(Console.ReadLine());
int digitPositionFirst = int.Parse(Console.ReadLine());
int digitPositionSecond = int.Parse(Console.ReadLine());

if (sixDigit < 100000 || sixDigit > 999999)
{
    Console.WriteLine("Enter 6 digit number");
}
else
{
    int num1 = sixDigit / 100000;
    int num2 = sixDigit / 10000 % 10;
    int num3 = sixDigit / 1000 % 10;
    int num4 = sixDigit / 100 % 10;
    int num5 = sixDigit / 10 % 10;
    int num6 = sixDigit % 10;

    int first = 0;
    int second = 0;


    if (digitPositionFirst == 1)
    {
        first = num1;
    }
    if (digitPositionFirst == 2)
    {
        first = num2;
    }
    if (digitPositionFirst == 3)
    {
        first = num3;
    }
    if (digitPositionFirst == 4)
    {
        first = num4;
    }
    if (digitPositionFirst == 5)
    {
        first = num5;
    }
    if (digitPositionFirst == 6)
    {
        first = num6;
    }


    if (digitPositionSecond == 1)
    {
        second = num1;
    }
    if (digitPositionSecond == 2)
    {
        second = num2;
    }
    if (digitPositionSecond == 3)
    {
        second = num3;
    }
    if (digitPositionSecond == 4)
    {
        second = num4;
    }
    if (digitPositionSecond == 5)
    {
        second = num5;
    }
    if (digitPositionSecond == 6)
    {
        second = num6;
    }

    int temp = first;
    first = second;
    second = temp;


    if (digitPositionFirst == 1)
    {
        num1 = first;
    }
    if (digitPositionFirst == 2)
    {
        num2 = first;
    }
    if (digitPositionFirst == 3)
    {
        num3 = first;
    }
    if (digitPositionFirst == 4)
    {
        num4 = first;
    }
    if (digitPositionFirst == 5)
    {
        num5 = first;
    }
    if (digitPositionFirst == 6)
    {
        num6 = first;
    }




    if (digitPositionSecond == 1)
    {
        num1 = second;
    }
    if (digitPositionSecond == 2)
    {
        num2 = second;
    }
    if (digitPositionSecond == 3)
    {
        num3 = second;
    }
    if (digitPositionSecond == 4)
    {
        num4 = second;
    }
    if (digitPositionSecond == 5)
    {
        num5 = second;
    }
    if (digitPositionSecond == 6)
    {
        num6 = second;
    }

    int result =
        (((((num1 * 10 + num2) * 10 + num3) * 10 + num4) * 10 + num5) * 10 + num6);

    Console.WriteLine(result);
}
