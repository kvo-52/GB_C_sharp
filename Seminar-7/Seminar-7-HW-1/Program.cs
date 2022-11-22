// Задача 1. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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
double[,] FillArray(int m, int n)
{
    double[,] array = new double[m,n];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*10-5;
        }
    }
    return array; 
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    double[,] tempArray = FillArray(intM, intN);
    PrintArray (tempArray);
}

Execute();