//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using System;
using static System.Console;
Clear();

Write("Введите число A: ");
int A = Convert.ToInt32(ReadLine());

Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());

WriteLine($"{Stepen(A, B)}");

int Stepen(int dig1, int dig2)
{
    int result = Convert.ToInt32(Math.Pow(dig1, dig2));
    return result;
}