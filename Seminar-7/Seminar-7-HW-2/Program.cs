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
bool ValidateNumber (int number1, int number2)
{
    if (number1<0 || number2<0)
    {
        System.Console.WriteLine("НЕВЕРНО! Необходимо ввести число > 0.");
        return false;
    }
    return true;
}

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

void CheckeElementArray(int[,] massiv, int number)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] == number)
            {
                System.Console.WriteLine($"Позиция [{i},{j}]соттветсвует введеному числу [{number}]");
                return;
            }
            
        }
    }
    System.Console.WriteLine("Такого элемента нет в массиве");
}

void FindElementArray(int[,] massiv, int indexI, int indexJ)
{
    if (indexI < massiv.GetLength(0) && indexJ < massiv.GetLength(1))
    {
        System.Console.WriteLine($"Позиция [{indexI},{indexJ}]соттветсвует числу [{massiv[indexI, indexJ]}]");
        return;
    }
    System.Console.WriteLine("Такого элемента нет в массиве");
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    System.Console.WriteLine();
    int[,] tempArray = FillArray(intM, intN);
    PrintArray(tempArray);
    System.Console.WriteLine();
    int indexI = PromptInt("Введите позицию элемента в строке: ");
    int indexJ = PromptInt("Введите позицию элемента в столбце: ");
    if (ValidateNumber(indexI, indexJ))
    {
     FindElementArray(tempArray, indexI, indexJ);   
    }
    System.Console.WriteLine();
    int number = PromptInt("Введите любое число: ");
    CheckeElementArray(tempArray, number);
}

Execute();