﻿// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да      7 -> да       1 -> нет

Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else
    Console.WriteLine("Не является выходным");