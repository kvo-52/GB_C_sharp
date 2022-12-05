// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма.
//  При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    string temp = System.Console.ReadLine();
    return temp;
}

void SecondArrayString(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string stringStart = Prompt("Введите строку из любых символов через пробел: ");
string[] array1 = stringStart.Split();
string[] array2 = new string[array1.Length];
Console.WriteLine();
SecondArrayString (array1, array2);
PrintArray (array2);


