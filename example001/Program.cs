// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1


try
{
    Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    if (num > 99 && num < 1000)
    {
        sum = num % 100;

        sum = sum / 10;
        Console.WriteLine(sum);
    }

    else if (num < -99 && num > -1000)
    {
        num = -num;

        sum = num % 100;

        sum = num % 100;

        sum = sum / 10;
        Console.WriteLine(sum);
    }
    else
        Console.WriteLine("Введите число от 100 до 999");

}
catch
{
    Console.WriteLine("Введите число цифрами от 100 до 999");
}
