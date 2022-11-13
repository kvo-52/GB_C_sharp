// Задача 1: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
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

int CheckingEvenArrayElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

int length = Prompt("Введите размер массива: ");
int[] numbers = new int[length];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int rezult = CheckingEvenArrayElements(numbers);
System.Console.WriteLine();
Console.WriteLine($"всего {length} чисел, {rezult} из них чётные");


