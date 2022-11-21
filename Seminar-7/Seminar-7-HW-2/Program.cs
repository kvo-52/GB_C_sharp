// Задача 2. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp))
    {
        return temp;
    }

    throw new Exception("Это не число!!!");
}

// int Prompt(string message)
// {
//     while (true)
//     try
//     {
//         return PromptInt(message);
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine($"Вы чтото неправильно ввели. Ошибка: {e.Message}");
//     }
// }


// int PromptInt(string strMessage)
// {
//     System.Console.Write(strMessage);
//     int temp = int.Parse(System.Console.ReadLine());
//     return temp;
// }

void PrintArray(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void CheckArray(int[,] massiv)
{
    int enterNumber = PromptInt("Введите целое число: ");
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] == enterNumber)
                Console.WriteLine("Такого числа в массиве нет");
        }
    }
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    int[,] tempArray = FillArray(intM, intN);
    PrintArray(tempArray);
    CheckArray(tempArray);
}

Execute();