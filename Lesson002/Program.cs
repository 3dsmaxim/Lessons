Console.Clear();

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10,100);
// Console.WriteLine(number);

// if (number/10 > number%10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
//     Console.WriteLine(number%10);
// }


// 1
// int number = new Random().Next(100, 1000);

// Console.WriteLine($" {number}, {(number / 100)*10 + number % 10}");



// 2

// Console.Write($"Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numB % numA == 0)
// {
//     Console.WriteLine($"{numB} кратно {numA}");
// }
// else
// {
//     if (numA < numB) Console.WriteLine($" остаток от деления {numB % numA}");

//     else
//     {
//         Console.WriteLine($"ошибка))))");
//     }
// }




// 3



// Console.Write($"Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// if (numA % 7 == 0 && numA % 23 == 0)
// {
//     Console.WriteLine($"число {numA} кратно  7 и 23");
// }
// else
// {

//     Console.WriteLine($"число {numA}  не кратно  7 и 23");

// }


// 4

// Console.WriteLine("Введите два числа для проверки, является ли один квадратом второго");
// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA == numberB * numberB) Console.WriteLine("число " + numberA + " квадрат числа " + numberB);

// else
// {
//     Console.WriteLine("число " + numberA + " не квадрат числа " + numberB);
// }

// if (numberB == numberA * numberA) Console.WriteLine("число " + numberB + " квадрат числа " + numberA);
// else
// {
//     Console.WriteLine("число " + numberB + " не квадрат числа " + numberA);
// }