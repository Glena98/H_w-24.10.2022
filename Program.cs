﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int Firstsecondnumber(int number)
{
    int firstnumber = number /10;
    int secondnumber = firstnumber % 10;
    int result = secondnumber;
    return result;
}

Console.WriteLine(Firstsecondnumber(num));

