﻿// Напишите программу, которая принимает на 
// вход трёхзначное число и удаляет вторую 
// цифру этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int first_num = num / 100;
int last_num = num % 10;

int result_num = (first_num * 10) + last_num;
Console.WriteLine(result_num);
