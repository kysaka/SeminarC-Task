// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int cutNumber(int num) 
// {
//     int hundreds = num / 10;
//     int units = num % 10;
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

Console.Write("Enter a number: ");
string number = (Console.ReadLine())!;

if (number.Length == 3)
{   
    int num = Convert.ToInt32(number);
    int units = num % 10;
    int result = units;
    Console.WriteLine($"The last digit: {result}");
}
else
{   
    if (number.Length > 3 && number.Length == 6)
    {
        int num = Convert.ToInt32(number);
        int hundreds = num / 1000;
        int units = hundreds % 10;
        int result = units;
        Console.WriteLine($"The last digit: {result}");
    }
    else
    {
        if (number.Length < 3 && number.Length != 6)
        Console.WriteLine("Enter a three-digit or six-digit number ");
    }
}


// Console.Write("Input a nuber: ");
// string input = Console.ReadLine();
// if (input.Length == 3)
// {
//     int number = Convert.ToInt32(input);
//     int lastDigit = number % 10;
//     Console.WriteLine($"The last digit: {lastDigit}");
// }
// else{
//     Console.WriteLine("Error! Enter a three-digit number.");
// };

