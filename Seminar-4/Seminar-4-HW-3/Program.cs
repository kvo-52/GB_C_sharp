// Задача 3: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int length=Prompt("Введите кол-во вводимых чисел: ");
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
 array[i] = Prompt("Введите числа: ");
}
PrintArray(array); 