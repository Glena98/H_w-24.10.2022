// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, 
// остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdnumber;
if (num/100 >= 1) 
{
    while (num/10>99) 
    {
        num = (num/10);
    }
    thirdnumber = (num % 10);
    Console.Write(thirdnumber);
}
else Console.Write("Третьей цифры нет.");


