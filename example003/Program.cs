// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


try
{
    Console.WriteLine("Введите цифру, обозначающую день недели, что бы узнать является ли он выходным: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if( num >0 && num < 6) Console.WriteLine(" нет ");
    else if (num >5 && num <8) Console.WriteLine(" да ");
    else Console.WriteLine(" Введите число от 1 до 7 ");
    
}
catch
{
    Console.Write("Введите число цифрами ");
}