// Семинар 2. Простые алгоритмы на C#

// ----- Задание 1. Совместная работа -----
// Напишите программу, которая принимает на 
// вход трёхзначное число и удаляет вторую 
// цифру этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81
// Решение
// bool finish_algorithm = false;
// do
// {
//   Console.Write("Введите трёхзначное число: ");
//   int num = Convert.ToInt32(Console.ReadLine());
//   if (num > 99 && num < 1000)
//   {
//     finish_algorithm = true;
//     int first_num = num / 100;
//     int last_num = num % 10;
//     int result_num = (first_num * 10) + last_num;
//     Console.Write("Задача решена. Результат: ");
//     Console.WriteLine(result_num);
//   }
//   else
//   {
//     Console.WriteLine("Число не трёхзначное!");
//   }
// } while (finish_algorithm == false);


// ----- Задание 2. Работа в сессионных залах -----
// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого 
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// Решение
// Console.Write("Выбранное трёхзначное число: ");
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int second_num = (num / 10) % 10;
// int last_num = num % 10;
// int result_num = 1;

// while (last_num > 0)
// {
//   result_num *= second_num;
//   last_num--;
// }
// Console.Write($"Задача решена. Результат: {result_num}");


// ----- Задание 3. Работа в сессионных залах -----
// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число 
// кратным второму. Если первое число некратно 
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1
// Решение
// Console.WriteLine("Введите первое число: ");
// int first_num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Второе число: ");
// int second_num = Convert.ToInt32(Console.ReadLine());
// int result = first_num % second_num;
// if (result == 0)
// {
//   Console.WriteLine($"{first_num}, {second_num} => Да, Первое число кратным второму");
// }
// else
// {
//   Console.WriteLine($"{first_num}, {second_num} => Нет, Первое число некратно второму. Остаток: {result}");
// }


// ----- Задание 4*. Совместная работа -----
// Напишите программу, которая выводит третью с 
// конца цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
// Решение
// int num = new Random().Next(1, 100000);
// Console.WriteLine(num);
// if (num < 100)
// {
//   Console.WriteLine($"{num} => Третьей цифры нет");
// }
// else
// {
//   while (num >= 1000)
//   {
//     num /= 10;
//   }
//   Console.WriteLine($"{num} => " + num % 10);
// }


// ----- Домашняя Задание -----
// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23
Console.WriteLine("Задача 1:");
int ex1_num = new Random().Next(7, 1000);
Console.WriteLine($"Число:{ex1_num}");

if (ex1_num % 7 == 0 && ex1_num % 23 == 0)
{
  Console.WriteLine($"Да, число: {ex1_num} => Одновременно кратно числам 7 и 23");
}
else
{
  Console.WriteLine($"Нет, число: {ex1_num} => Одновременно не кратно числам 7 и 23");
}

// Задача 2: Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
Console.WriteLine("Задача 2:");
int x_coor = new Random().Next(-5, 6);
int y_coor = new Random().Next(-5, 6);
if (x_coor != 0 && y_coor != 0)
{
  if (x_coor > 0 && y_coor > 0)
  {
    Console.WriteLine($"X = {x_coor}, Y = {y_coor} => Номер координатной четверти плоскости: 1");
  }
  else if (x_coor < 0 && y_coor > 0)
  {
    Console.WriteLine($"X = {x_coor}, Y = {y_coor} => Номер координатной четверти плоскости: 2");
  }
  else if (x_coor < 0 && y_coor < 0)
  {
    Console.WriteLine($"X = {x_coor}, Y = {y_coor} => Номер координатной четверти плоскости: 3");
  }
  else
  {
    Console.WriteLine($"X = {x_coor}, Y = {y_coor} => Номер координатной четверти плоскости: 4");
  }
}
else
{
  Console.WriteLine("Координаты не должны быть равно к нулю!!!");
}

// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
Console.WriteLine("Задача 3:");
int ex3_num = new Random().Next(10, 100);
Console.WriteLine($"Число:{ex3_num}");
int ex3_first_num = ex3_num / 10;
int ex3_second_num = ex3_num % 10;
if (ex3_first_num > ex3_second_num)
{
  Console.WriteLine($"Первое число:{ex3_first_num} больше чем второе число:{ex3_second_num}");
}
else if (ex3_first_num < ex3_second_num)
{
  Console.WriteLine($"Второе число:{ex3_second_num} больше чем первое число:{ex3_first_num}");
}
else
{
  Console.WriteLine($"Первое число:{ex3_first_num} равен второму числу:{ex3_second_num}");
}

// Задача 4: Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.
Console.WriteLine("Задача 4:");
int ex4_num = new Random().Next(1, 100000000);
int r4_num = ex4_num;
Console.WriteLine($"Число:{ex4_num}");
if (ex4_num < 10)
{
  Console.WriteLine($"Число: {ex4_num} => {ex4_num}");
}
else
{
  string s_num = string.Empty;
  while (ex4_num >= 10)
  {
    int r_num = ex4_num % 10;
    s_num = Convert.ToString(r_num) + "," + s_num;
    ex4_num /= 10;
  }
  Console.WriteLine($"{r4_num} => {ex4_num},{s_num.Remove(s_num.Length - 1)}");
}