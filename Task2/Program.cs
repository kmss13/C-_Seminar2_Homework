// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ReadNumber(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool ValidateThree(int number)
{
    if (number >= 100)
    {
        return true;
    }
    Console.WriteLine($"В числе {number} меньше трех цифр");
    return false;
}

int num = ReadNumber("Введите число ");

if (ValidateThree(num))
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdNum = num % 10;

    Console.WriteLine($"Третья цифра числа  равна {thirdNum}");

}






