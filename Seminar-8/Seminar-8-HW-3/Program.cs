// Задача 3: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateRandomArrayOfInt(int rows, int cols) // Создает двумерный массив с заданой размерностью и границами генерации целых чисел
{
    int[,] temp = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            temp[i, j] = new Random().Next(1, 10);
        }
    }
    return temp;
}

void PrintArrayOfInt(int[,] array) // Печать двумерного массива целых чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i, 0]}\t");
        for (int j = 1; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiyArray(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)//произведение двух матриц 
{

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

void Main()
{
    System.Console.Clear();
    System.Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
    int rowsInArray1 = Prompt("Введите число строк 1-й матрицы: ");
    int colsInArray1 = Prompt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
    int colsInArray2 = Prompt("Введите число столбцов 2-й матрицы: ");
    System.Console.WriteLine();
    int[,] firstMartrix = CreateRandomArrayOfInt(rowsInArray1, colsInArray1);
    int[,] secondMartrix = CreateRandomArrayOfInt(colsInArray1, colsInArray2);
    PrintArrayOfInt(firstMartrix);
    System.Console.WriteLine();
    PrintArrayOfInt(secondMartrix);
    System.Console.WriteLine();
    int[,] resultMatrix = new int[rowsInArray1, colsInArray2];
    int[,] newMartrix = MultiyArray(firstMartrix, secondMartrix, resultMatrix);
    PrintArrayOfInt(newMartrix);

}

Main();