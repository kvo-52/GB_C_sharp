// Задача 3: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double MinArrayElements(double[] array)
{
    double minArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minArray)
            minArray = array[i];
    }
    return minArray;
}

double MaxArrayElements(double[] array)
{
    double maxArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArray)
            maxArray = array[i];
    }
    return maxArray;
}


int length = Prompt("Введите размер массива: ");
double[] numbers = new double[length];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = MinArrayElements(numbers);
double max = MaxArrayElements (numbers);
double def = max-min;
System.Console.WriteLine();
Console.WriteLine($"разницу между максимальным и минимальным элементов массива  = {def:f2}");