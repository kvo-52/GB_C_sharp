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

void PrintArray (double[,] arrNums)
{
    for (int i=0; i<arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]:f2}");
        for (int j=1; j<arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]:f2}");
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

int ArithmeticMeanAerray(int[,]array)
{
    ArithmeticMean=0;
    for (int j=1; j<arrNums.GetLength(1); j++)
        {
            ArithmeticMean=array[i,j];
        }
        return ArithmeticMean;
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    int[,] tempArray = FillArray(intM, intN);
    PrintArray(tempArray);
    ArithmeticMeanAerray(tempArray);
}

Execute();
