﻿/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int numThreeDigit = Convert.ToInt32(Console.ReadLine());

if (numThreeDigit < 100 || numThreeDigit > 999) {
    Console.WriteLine("Число не является трехзначным.");
}
else {
    Console.WriteLine($"Вторая цифра числа {numThreeDigit}" + 
                        $"-> {(numThreeDigit % 100) / 10}");
}