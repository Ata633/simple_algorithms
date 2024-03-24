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
Console.Write("Выбранное трёхзначное число: ");
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int second_num = (num / 10) % 10;
int last_num = num % 10;
int result_num = 1;

while (last_num > 0)
{
  result_num *= second_num;
  last_num--;
}
Console.Write($"Задача решена. Результат: {result_num}");