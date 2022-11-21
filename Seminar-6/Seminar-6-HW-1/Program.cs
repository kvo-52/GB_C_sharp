// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int InputArrayNumbers(int length)
{
    int[] arrayNew = new int[length];
    for (int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = Prompt($"Введите {i+1}-е число: ");
    }
    return arrayNew;
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CheckingArrayElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count+=1;
    }
    return count;
}

int length = Prompt("Введите количество чисел: ");
int [] arrayNumber = InputArrayNumbers(length);
PrintArray(arrayNumber);
int rezult = CheckingArrayElements(arrayNumber);
System.Console.WriteLine();
Console.WriteLine($"всего чисел больше нуля: {rezult}");