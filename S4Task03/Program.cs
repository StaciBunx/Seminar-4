//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Clear();

int[] array = new int[8];
CreatePrintArray(array);


void CreatePrintArray(int[] massiv)
{
    int L = massiv.Length;
    int adress = 0;
    while(adress<L)
    {
        massiv[adress] = new Random().Next(1, 100);
        adress++;
    }
        WriteLine($"[{String.Join(",", massiv)}]");

}
