//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine());
WriteLine($"{Sum(num)}");

int Sum(int Number)
{
    int result = 0;

    while (Number > 0)
    {
        result += Number % 10;
        Number = Number / 10;
    }
    return result;
}
