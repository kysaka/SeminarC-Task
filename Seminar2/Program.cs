// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int cutNumber(int num) 
// {
//     int hundreds = num / 10;
//     int units = hundreds % 10;
//     int result = units;

//     return result;
// }

// int randNumber = new Random().Next(100,1000);

// int newNumber = cutNumber(randNumber);

// Console.WriteLine($"New wersian of {randNumber} is {newNumber}");

// ------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = ReadInt("Enter a number: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int number, int count)
// {
// int result = 0;
//     if (count < 3)
//     {
//         Console.Write("There is no third digit, hold it: ");
//     }
//     else
//     {
//         int current = 1;
//         for (int i = count; i > 3; i--)
//         {
//             current = current * 10;
//         }

//         result = (number / current) % 10;
//     }
// return result;
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool weekDay(int num)
// {
//         return (num == 6 || num == 7);
// }

// Console.Write("Enter the day of the week: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = weekDay(num);

// if(result)
// {
//     Console.WriteLine("This day is a day off ");
// }
// else
// {
//     Console.WriteLine("This day is not a day off ");
// }