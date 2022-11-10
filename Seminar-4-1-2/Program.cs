// Напишите программу, которая принимает на вход число и
//  выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int NumberDigit(int UserAnswer)
{
    int count=0;
    while(UserAnswer>=1)
    {
        UserAnswer=UserAnswer/10;
        count++;
    }
    return count;
}

int number = Prompt("Введите число: ");
int count=NumberDigit(number);
Console.WriteLine($"Количество чисел {count}");
