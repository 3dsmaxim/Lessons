Console.Clear();


// 39 Напишите пограмму, которая перевернет одномерный массив( последний будет на первом месте последний на первом и тд)


// int[] ArrayNew(int num)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// int[] ArrayChengReplac(int[] ar)
// {
//     int[] arrTwo = new int[ar.Length];
//     for (int i = 0; i < ar.Length; i++)
//     {
//         // int namberTwo = ar.Length - 1;
//         arrTwo[i] = ar[ar.Length - 1 - i];

//     }
//     return arrTwo;

// }


// Console.WriteLine("Введите размерность массива");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arrayTwo = ArrayNew(number);

// Console.WriteLine($"[{String.Join(", ", arrayTwo)}] наоборот [{String.Join(", ", ArrayChengReplac(arrayTwo))}] ");


// int[] array= ArrayNew(number);




// 40  напишите программу которая на вход принимает 3 числа и проверяет их,  
// может ли существовать треугольник с сторонами такой длинны

// int[] ArrayNew(int num)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }


//     Console.WriteLine("Введите размерность массива");
// int number = 3;
// int[] arrayTwo = ArrayNew(number);
// bool questin = false;
// if (arrayTwo[0] < arrayTwo[1] + arrayTwo[2] && arrayTwo[0] + arrayTwo[1] > arrayTwo[2] && arrayTwo[2] + arrayTwo[0] > arrayTwo[1]) questin = true;

// Console.WriteLine($"[{String.Join(", ", arrayTwo)}], {(questin? "да":"нет")} ");


// 42 напишите программу преобразования десятичного числа в двоичное

// Console.WriteLine("Введите целое число");
// int number = int.Parse(Console.ReadLine());


// string biNum(int num)
// {
//     int numA = num;
//     string numB = string.Empty;
//     string numC = string.Empty;

//     while (numA != 0)
//     {
//         numB = numB + $"{numA % 2}";
//         numA = (numA - numA % 2) / 2;

//     }
//     int numD = numB.Length - 1;
//     for (int i = 0; i < numB.Length; i++)
//     {
//         numC = numC + numB[numD];
//         numD -= 1;

//     }

//     return numC;
// }
// Console.Write($"число {number} в двоичке {biNum(number)} ");


// Задача 44:  не используя рекурсию, выведете первые N чисел фибоначи. Первые 2 числа фибоначи 2 и 1



// string FiboNum(int number)
// {
//     int numA = number;
//     string numB = string.Empty;
//     int numD = 0;
//     int numE = 1;
//     int numF = 0;
//     numB = numB + $"{numD}" + $"{numE}";
//     for (int i = 2; i < number; i++)
//     {
//         numB = numB + $"{numD + numE}";
//         numF = numD + numE;
//         numD = numE;
//         numE = numF;

        

//     }
//     return numB;
// }


// Console.WriteLine(" ВВедите число N число больше 3");
// int numN = int.Parse(Console.ReadLine());
// while (numN <= 2)
// {
//     Console.WriteLine(" ВВедено неверное число, введите целое число больше 3");
//     numN = int.Parse(Console.ReadLine());
// }

// Console.Write($"первые {numN} чисет Фибоначи {FiboNum(numN)}.");

// задача 45: напишите прогамму котоая будет создавать копию  массива поэлементно

int[] ArrayNew(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int[] ArrayCopy(int[] ar)
{
    int[] arrTwo = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        // int namberTwo = ar.Length - 1;
        arrTwo[i] = ar[i];

    }
    return arrTwo;

}


Console.WriteLine("Введите размерность массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayTwo = ArrayNew(number);
int[] arrayTwoTwo = ArrayCopy(arrayTwo);

Console.WriteLine($"[{String.Join(", ", arrayTwo)}] копия [{String.Join(", ", arrayTwoTwo)}] ");