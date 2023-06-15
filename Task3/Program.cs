// Написать программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.

string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскременье" };

Console.Write("Введите день недели ");
string day = Console.ReadLine();
int dayNumber = Convert.ToInt32(day);

if (dayNumber <= 0 || dayNumber > 6)
{
    Console.WriteLine("Введите цифру от 1 до 6");
}
else
{
    Console.WriteLine(week[dayNumber - 1]);
}

