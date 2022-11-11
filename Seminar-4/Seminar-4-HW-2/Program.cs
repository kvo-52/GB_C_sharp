// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

 bool ValidateNumber(int number)
{
    if ( number<=0)
    {
        System.Console.WriteLine("Число должно быть больше нуля");
        return false;
    }
    return true;
}

int NumberDigit(int UserAnswer)
{
    int count = 0;
    while (UserAnswer >= 1)
    {
        UserAnswer = UserAnswer / 10;
        count++;
    }
    return count;
}

int SumNumbers(int number, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


int number = Prompt("Введите число: ");
if (ValidateNumber(number))
{
    int length = NumberDigit(number);
    int sum = SumNumbers(number, length);
    Console.WriteLine($"Сумму цифр в числе {number} = {sum}");
}
