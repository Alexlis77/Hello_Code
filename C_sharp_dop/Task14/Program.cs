﻿/*
У американского писателя-фантаста Рэя Бредбери 
есть роман «450 градусов  по Фаренгейту».
Какой температуре по шкале Цельсия 
соответствует указанное в названии значение? 
*/

Console.WriteLine("450 градусов по Фаренгейту соответствует: ");
Console.WriteLine($"{string.Format("{0:N2}", (450 - 32) / 1.8)} градусов по Цельсию ");
Console.WriteLine($"{string.Format("{0:N2}", ((450 - 32) / 1.8) + 273.15)} градусов по Кельвину ");