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

bool ValidateNumber(int number)
{
    if ( number>0)
    {
        System.Console.WriteLine("Число должно быть больше нуля");
        return false;
    }
    return true;
}

int FhreeDigitNumber (int[] array)
{

}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

int length=Prompt("Введите длину массива: ");
int min= ValidateNumber(number);
int max= ValidateNumber(number);
int[] array = CreateArray(length, min, max);

System.Console.WriteLine();
System.Console.WriteLine($"количество чётных чисел в массиве -> {rezult}");