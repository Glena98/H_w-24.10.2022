// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstnum;
int secondnum;

if (num/1000>=1)
{
    firstnum = num%100;
    secondnum = num/1000;
    if (num%10 == num/10000 && firstnum/10 == secondnum%10)
    {
        Console.WriteLine($"{num} - да");
    }
    else
    {
        Console.WriteLine($"{num} - нет");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число ");
}


