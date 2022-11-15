// Задача 4 (*) При помощи рекурсии вывести последовательность чисел,
//  с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

// int Prompt(string strMessage)
// {
//     System.Console.Write(strMessage);
//     int temp = int.Parse(System.Console.ReadLine());
//     return temp;
// }

// int ArrayNumbersRecurs(int length)
// {
//     int numb = 0;
//     int j = 0;
//     if (length == 1) return 1;
//     else
//     {
//         for (int i = 0; numb < length; i++)
//         {
//             numb += i;
//             j = i;
//         }
//         return (ArrayNumbersRecurs(--length) + j);
//     }

// }


// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int length = Prompt("Введите число: ");
// int[] numbers = new int[length];
// ArrayNumbersRecurs(length);
// PrintArray(numbers);

// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством
// этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5
int ReqSeq(int n)
{
    int sum = 0;
    int j = 0;
    if (n == 1)
    {
        Console.Write(1);
        return 0;
    }
    else
    {
        for (int i = 1; sum < n; i++)
        {
            sum += i;
            j = i;
        }
        Console.Write(ReqSeq(--n)  + j);
        return 0;
    }
}

int s = ReqSeq(15);
