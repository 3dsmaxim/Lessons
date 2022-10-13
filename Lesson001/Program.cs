Console.Clear();

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // int sqrt = number * number;
// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));



// Console.WriteLine("Число возведенное в квадлрат: " + sqrt1);


// // 1 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // int sqrt = number * number;
// // number *= number;
// // number = number * number;
// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Число в квадрате: " + sqrt1);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.WriteLine("Введите два числа для проверки, является ли один квадратом второго");
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("число " + numberA + " квадрат числа " + numberB);
}
else
{
    Console.WriteLine("число " + numberA + " не квадрат числа " + numberB);
}

// 5 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
// if (num > 99 && num <= 999)
// {
//     Console.Write("Последняя цифра: " + num % 10);
// }
// else
// {
//     Console.WriteLine("Введенное число не трехзначное");
// }
