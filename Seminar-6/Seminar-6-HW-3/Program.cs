﻿void FillArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MaxArray(int[,] image) 
{
    int sum = 0;
    for (int j = 0; j < image.GetLength(0); j++)
    {
        int tempMax = image[j, 0];
        for (int i = 0; i < image.GetLength(1); i++)
        {
            if (tempMax < image[j, i])
            {
                tempMax = image[j, i];
            }
        }
        sum += tempMax;
    }
    return sum;
}

int MinArray(int[,] image) 
{
    int sum = 0;
    for (int j = 0; j < image.GetLength(1); j++)
    {
        int tempMin = image[0, j];
        for (int i = 0; i < image.GetLength(0); i++)
        {
            if (tempMin > image[i, j])
            {
                tempMin = image[i, j];
            }
        }
        sum += tempMin;
    }
    return sum;
}

int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);
Console.Write($"Сумма максимумов: ");
Console.WriteLine(MaxArray(matrix));
Console.Write($"Сумма минимумов: ");
Console.WriteLine(MinArray(matrix));
Console.Write($"Разница сумм: ");
Console.WriteLine(MaxArray(matrix) - MinArray(matrix));

