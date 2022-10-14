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

// Console.WriteLine("Введите два числа для проверки, является ли один квадратом второго");
// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA == numberB * numberB)
// {
//     Console.WriteLine("число " + numberA + " квадрат числа " + numberB);
// }
// else
// {
//     Console.WriteLine("число " + numberA + " не квадрат числа " + numberB);
// }






// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.Write("Введите номер дня недели: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// if (Num > 0 && Num < 8)
// {
//     if ((Num > 0 && Num < 8) & (Num == 1))
//     {
//         Console.WriteLine("Понедельник");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 2))
//     {
//         Console.WriteLine("Вторник");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 3))
//     {
//         Console.WriteLine("Среда");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 4))
//     {
//         Console.WriteLine("Четверг");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 5))
//     {
//         Console.WriteLine("Пятница");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 6))
//     {
//         Console.WriteLine("Суббота");
//     }
//     if ((Num > 0 && Num < 8) & (Num == 7))
//     {
//         Console.WriteLine("Воскресенье");
//     }
// }
// else
// {
//     Console.WriteLine("Неверный ввод числа");
// }



// 5. Напишите программу, которая на вход принимает 
//одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// int count = 0;
// Console.WriteLine("Ввведите число чтобы получить интерва от -N до +N");
// int numberI = Math.Abs((Convert.ToInt32(Console.ReadLine())));
// if (numberI > 0)
// {
//     int numberB = numberI * (-1);

//     while (count < numberI + numberI + 1)

//     {

//         Console.Write(numberB + ", ");
//         numberB = numberB + 1;
//         count = count + 1;
//     }

// }
// else
// {
//     int numberB = numberI;
//     Console.Write(numberB + ", ");
// }






// 7 Напишите программу, которая принимает на вход трёхзначное число 
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
