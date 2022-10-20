Console.Clear();

// // Задача 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// int GetQuaterFromCoodinate(int userX, int userY)
// {
//     int quater = 0;
//     if (userX > 0 && userY > 0)
//     {
//         quater = 1;
//     }
//      if (userX < 0 && userY > 0)
//     {
//         quater = 2;
//     }
//      if (userX < 0 && userY < 0)
//     {
//         quater = 3;
//     }
//      if (userX > 0 && userY < 0)
//     {
//         quater = 4;
//     }

//     return quater;
// }
// Console.WriteLine(" Введите Х");
// int userX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите Y");
// int userY = Convert.ToInt32(Console.ReadLine());

// int quater = GetQuaterFromCoodinate(userX, userY);
// if (quater != 0)
// {
// Console.WriteLine($" Точка в {quater} четверти ");
// }
// else Console.WriteLine($" Точка на оси ");




// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int quater = Convert.ToInt32(Console.ReadLine());
// if (quater >= 1 && quater <= 4)
// {
//     if (quater == 1) Console.WriteLine("Диапазон Х от 0 до + бесконечности, Диапазон Y от 0 до + бесконечности ");
//     if (quater == 2) Console.WriteLine("Диапазон Х от 0 до - бесконечности, Диапазон Y от 0 до + бесконечности ");
//     if (quater == 3) Console.WriteLine("Диапазон Х от 0 до - бесконечности, Диапазон Y от 0 до - бесконечности ");
//     if (quater == 4) Console.WriteLine("Диапазон Х от 0 до + бесконечности, Диапазон Y от 0 до - бесконечности ");
// }
// else Console.WriteLine("Ввели не то");











// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



// Console.WriteLine(" Введите Х первой точки");
// int userXa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите Y первой точки");
// int userYa = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" Введите Х второй точки");
// int userXb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите Y второй точки");
// int userYb = Convert.ToInt32(Console.ReadLine());


// double l = Math.Sqrt(Math.Pow((userXa - userXb), 2) + Math.Pow((userYa - userYb), 2));

// Console.WriteLine($"Расстояние между точками равно {Math.Round(l, 2)}");




// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.Write(" Введите целое число больше 1: ");
// int userN = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < userN; i++)
// {
//     Console.Write($"квадрат {i} = {i * i}, ");

// }
// Console.WriteLine($"квадрат {userN} = {userN * userN}.");


