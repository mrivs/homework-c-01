﻿/*/
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
/*/

Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine());
string str="";

for (int i = 1;i<=N;i++) {

    if (i%2==0) str=str+i+", ";
}

str=str.Substring(0, str.Length - 2);
Console.WriteLine(str);
