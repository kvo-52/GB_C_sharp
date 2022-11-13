// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

// int[] FillArrayRandomNumbers(int length, int min, int max)
// {
//     int[] tempArray = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         tempArray[i] = new Random().Next(min, max+1);
//     }
//     return tempArray;
// }

void FillArrayRandomNumbers(int[] numbers, int min, int max)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min,max);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumArrayElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum=sum+array[i];
    }
    return sum;
}

int length=10;
int min = -9;
int max = 9;
int[] numbers = new int[length];
FillArrayRandomNumbers(numbers, min, max);
PrintArray(numbers);
int sum = SumArrayElements(numbers);
System.Console.WriteLine();
Console.WriteLine($"Сумма четных элементов  = {sum}");