// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30



int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}
bool ValidateNumber(int number)
{
    if (number <= 0)
    {
        System.Console.WriteLine("Число должно быть положительным");
        return false;
    }
    return true;
}
void SumPrintNumbersMN (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumPrintNumbersMN(numberM, numberN, sum);
}

void Execute()
{
    int numberM = PromptInt("Введите число M: ");
    if (ValidateNumber(numberM))
    {
        int numberN = PromptInt("Введите число N: ");
        if (ValidateNumber(numberN))
        {
            SumPrintNumbersMN(numberM, numberN, 0);
        }
    }
    
}

Execute();


