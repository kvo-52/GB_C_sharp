// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray(double[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]:f2}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]:f2}");
        }
        System.Console.WriteLine("");
    }
}

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

double[] ArithmeticMeanAerray(double[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average[j] += array[i, j];
        }
        average[j] = average[j] / array.GetLength(0);
    }
    return average;
}

void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    double[,] tempArray = FillArray(intM, intN);
    PrintArray(tempArray);
    Console.WriteLine();
    Console.WriteLine($"Среднее арифметическое каждого столбца: ");
    PrintAverage(ArithmeticMeanAerray(tempArray));
}

Execute();
