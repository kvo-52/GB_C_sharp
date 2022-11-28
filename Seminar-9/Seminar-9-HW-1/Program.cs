// Задача 1: Задайте значения M и N. Напишите программу,
//  которая выведет все чётные натуральные числа в промежутке от M до N 
//  с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


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

void PrintNumbersMN(int m, int n)
{
    if (m <= n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(n);
        }

        PrintNumbersMN(m, n - 1);
    }
}

void Execute()
{
    int numberM = PromptInt("Введите число M: ");
    if (ValidateNumber(numberM))
    {
        int numberN = PromptInt("Введите число N: ");
        if (ValidateNumber(numberN))
        {
            PrintNumbersMN(numberM, numberN);
        }
    }

}

Execute();