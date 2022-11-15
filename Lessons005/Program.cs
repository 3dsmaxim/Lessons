Console.Clear();
// Задача №32 напишите программу замена элементов массива: все положительные элементы замениет на соответствующие отрицательные и наоборот


// Console.WriteLine("Введите размерность массива");
// int l = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[l];

// int[] InputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"Введите{i + 1}-e  число массива");
//         arr[i] = Convert.ToInt32(Console.ReadLine());

//     }
//     return arr;
// }

// int[] ArrayInvert(int[] arrTo)
// {
//    for (int i = 0; i < arrTo.Length; i++)
//     {

//         arrTo[i] =  arrTo[i]*(-1);

//     }
//     return arrTo; 
// }


// Console.Write($"[{String.Join(" ,", InputArray(array))}],");
// Console.WriteLine($" инвертированный знак [{String.Join(" ,", ArrayInvert(array))}]");


// Задача №33  задайте масси. напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Console.WriteLine("Задайте массив");
// Console.WriteLine("Введите размерность массива");
// int l = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[l];
// Console.Clear();
// Console.WriteLine($"Массив [{String.Join(", ", EnterArray(array))}]");
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine($"число {num} {NumIn(array, num)}");





// int[] EnterArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"Введите{i + 1}-e  число массива");
//         arr[i] = Convert.ToInt32(Console.ReadLine());

//     }
//     return arr;
// }

// bool ser = false;
// for (int i = 0; i < array.Length; i++)
// {

//     if (array[i] == num)
//     {

//         ser = true;
//     }

// }



// Console.WriteLine($"число {num} {(ser ? "имеется": "не имеется")} в массиве [{String.Join(", ", array)}]");




// Задача № 35 Задайте одномерный массив и 123 случайных чисел.
// найдите колличество элементов массива в отрезке [10, 99]






// int[] ArrayNew(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 4000);
//     }
//     return arr;
// }

// int CountArray(int[] arr)
// {

//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {


//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count++;
//         }

//     }
//     return count;

// }

// int[] array = new int[123];
// ArrayNew(array);
// // Console.WriteLine($"в массиве [{String.Join(" ,", ArrayNew(array))}] значений на отрезке[10, 99]");
// Console.WriteLine($"в массиве {CountArray(array)} значений на отрезке [10, 99]");



// задача № 37 Найдите произведение пар чисел в одномерном массиве
// Посчитайте первый и последний, второй и последний и тд.
//результат запишите в новом массиве

int[] ArrayNew(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 11);
    }
    return arr;
}

int[] ArreyTo(int[] arr)
{
    int arth = arr.Length;
    int line = 0;
    if (arr.Length % 2 > 0)
    {
        line = arr.Length / 2 + 1;

    }
    else
    {
        line = arr.Length / 2;

    }
    int[] array = new int[line];

    if (arr.Length % 2 > 0)
    {
        for (int i = 0; i < line-1; i++)
        {
            arth = arth - 1;
            array[i] = arr[i] * arr[arth];
        }
        array[line-1] = arr[line-1];
    }
    else
    {
        for (int i = 0; i < line; i++)
        {
            arth = arth - 1;
            array[i] = arr[i] * arr[arth];
        }


    }


    return array;
}

Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int[] arrayT = ArrayNew(array);
Console.WriteLine($"массив [{String.Join(" ,", array)}]");
Console.WriteLine($"массив [{String.Join(" ,", ArreyTo(arrayT))}]");