//Задача 1: Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.

// using System;

// int GetUserInput(string str)
// {
//     Console.WriteLine(str);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// bool DivisionTo(int num, int num1, int num2)
// {
//     return num%num1==0 && num % num2 ==0;
// }

// int number = GetUserInput("Enter number");
// bool div7a23 = DivisionTo(number,7,23);
// Console.WriteLine(div7a23 ? "да": "нет");

// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// using System;
// int GetUserInput(string str)
// {
//     Console.WriteLine(str);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int Quater(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0; //x ==0 y == 0

// }

// int xCoordinate = GetUserInput("Ведите х:");
// int yCoordinate = GetUserInput("Ведите y:");
// int quater = Quater(xCoordinate, yCoordinate);

// //Вывод координатной сетки
// Console.WriteLine("2|1");
// Console.WriteLine("---");
// Console.WriteLine("3|4");

// string result = quater > 0

               
// Console.WriteLine(result);



// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// using System;
// int number = new Random().Next(10, 100);//99+1
// Console.WriteLine($"случайное число из отрезка [10, 99]={number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"наибольшая цифра числа {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"наибольшая цифра числа {secondDigit}");
// }
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор альтернатива if
// Console.WriteLine(maxDigit);



// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры 
// через запятую.
 
// using System;
// Console.WriteLine("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// {
//     if (N < 10)
//     {
//         Console.WriteLine(N);
//     }
//     else {
//         while (N > 0);
//     }
//     int currentDigit = N % 10;
//     N /= 10;
    
//     if (N > 0)
//     {
//         Console.Write(currentDigit + ",");
//     }
// }

