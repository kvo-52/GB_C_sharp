// Задача 1: Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int number)
{
    if ( number<=0)
    {
        System.Console.WriteLine("Число должно быть положительным");
        return false;
    }
    return true;
}

int SumNambers(int number)
{
    int sum=0;
    for (int i=1; i<=number; i++)
    {
        sum+=i;
    }
    return sum;
}

int SumGauss(int number)
{
    return (int)((number/2.0)*(1+number));
}

int number = Prompt("Введите число");
if (ValidateNumber(number))
{
    int sum =SumNambers(number);
    int sumGauss = SumGauss(number);
    System.Console.WriteLine($"Суума чисел от 1 до {number} до {sum}, а Гаусс, что {sumGauss}");
}