// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трехзначное число: ");
try
{
    int i = Convert.ToInt32(Console.ReadLine());
    char[] arr = i.ToString().ToCharArray();                // переводит число в массив
    int size = arr.Length;
    if (size == 3)
    {
        Console.WriteLine(arr[1]);
    }
    else
    {
        Console.WriteLine("Введите число от 100 до 999 ");
    }
}

catch
{
    Console.WriteLine("Введите число цифрами");
}



  


