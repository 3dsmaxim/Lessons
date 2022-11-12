Console.Clear();



// void GetSumNums(int number)
// {
//     int sum = 0;

//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     Console.WriteLine($"сумма цифр от 1 до числа: {sum}");
// }
// Console.Clear();
// GetSumNums(16);


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int sum = GetCountNums(num);
// Console.WriteLine($"Количество цифр = {sum}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


// int GetCountNums(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }




int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(",                              ", array)} ]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
        result[i] = new Random().Next(2);
}
    return result;
}



