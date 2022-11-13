// Задача 4 (*) При помощи рекурсии вывести последовательность чисел,
//  с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int FillArrayNumbers(int[] numbers, int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[0] = 1;
        if (numbers[i] - i == numbers[i + 1] - (i + 1))
            return numbers[i] = numbers[i] + 1;
        else FillArrayNumbers();
    }
    return tempArray;

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

int length = Prompt("Введите число: ");
int[] numbers = new int[length];
FillArrayNumbers(numbers);
PrintArray(numbers);