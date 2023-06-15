// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
string inputString = Console.ReadLine();
int number = Convert.ToInt32(inputString);


    if (number >= 100 && number < 1000)
    {
    int secondNum = (number / 10) % 10;
        Console.WriteLine($"Вторая цифра числа {number} равна {secondNum}");
    }
    else
    {
        Console.Write("Число не трехзначно.Введите трехзначное число");
    }





