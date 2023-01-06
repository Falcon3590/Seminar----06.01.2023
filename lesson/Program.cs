// int x = new Random().Next(10,100);
// Console.WriteLine("Было сгенерированно число "+ x);
// Console.WriteLine($"Было сгенерированно число {x}");
// int x1 = x / 10;
// int x2 = x % 10;
// if (x1 > x2) Console.WriteLine(x1);
// else if (x1<x2) Console.WriteLine(x2);
// else Console.WriteLine("Цифры числа одинаковые");



// 1. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int x = new Random().Next(100,100000);

// Console.WriteLine("Было сгенерированно число: " + x);

// int x1 = x / 100;
// int x2 = x % 100;
// int x3 = x % 10;


// Console.WriteLine($"{x1}{x3}");


// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// Console.WriteLine("Введите первое число: ");

// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");

// int y = Convert.ToInt32(Console.ReadLine());

// int temp = y % x;

// if (temp == 0)
// {
//     Console.WriteLine($"Второе число {y} кратно первому {x}");
// }
// else
// {
//     Console.WriteLine($"Второе число {y} не кратно первому {x} Остаток от деления {y} на {x} = " + temp);
//     // Console.WriteLine($"Остаток от деления {y} на {x} = " + temp);
// }


// 1. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x % 7 == 0 && x % 23 == 0)
// {
//     Console.WriteLine($" Число {x} кратно 7 и кратно 23 ");

// }
// else
// {
//     Console.WriteLine($" Число {x} не кратно 7 и не кратно 23 ");
// }



// 2. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


// Console.WriteLine("Введите первое число: ");

//  int x = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine("Введите второе число: ");

//  int y = Convert.ToInt32(Console.ReadLine());

//  if (x == y*y || y == x*x) 
//  {
//      Console.WriteLine($" число является квадратом  ");

//  }
//  else
//  {
//      Console.WriteLine($" квадрат отсутсвует ");
//  }



// int N = new Random().Next(1, 65536);
// int n = N;
// if (N <= 99)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     while (N > 999)
//         {
//             N = N / 10;
//         }
//     int result = N % 10;
//     Console.Write($"{result} является третей цифрой от числа {n}");
// }    
