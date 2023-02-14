// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение: 

// Console.Write("Input an integer nuber: "); 
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input an integer nuber: "); 
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num > num2)
// {
//     Console.WriteLine("Maximum number " + num);
//     Console.WriteLine("Minimum number " + num2);
// }
// else
// {
//     Console.WriteLine("Maximum number " + num2);
//     Console.WriteLine("Minimum number " + num);
// }

// ----------------------------------------------------

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:

// Console.Write("Input an integer nuber: "); 
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input an integer nuber: "); 
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input an integer nuber: "); 
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num > num3 && num > num2)
//     Console.WriteLine("Maximum number " + num);
// {
//     if (num2 > num && num2 > num3)
//     Console.WriteLine("Maximum number " + num2);
// }
// {
//     if (num3 > num && num3 > num2)
//     Console.WriteLine("Maximum number " + num3);
// }

// ----------------------------------------------------

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input an integer nuber: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Not even");
// }

// ----------------------------------------------------

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input an integer nuber: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input an integer nuber: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// for (int i = num; i <= num2; i++)
// {
//     if (i % 2 == 0) 
//         {
//             Console.Write(i + " ");
//         }
// }