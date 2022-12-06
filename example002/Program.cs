// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

try
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    if (num < -99) num = -num;

    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }

        sum = num % 100;
        sum = num % 10;
        Console.Write("Третья цифра в вашем числе: ");
        Console.WriteLine(sum);
    }
    else Console.WriteLine("Третьей цифры нет");
}
catch
{
    Console.Write("Введите число цифрами! ");
}