// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}
bool ValidateNumber(int number)
{
    if (number < 0)
    {
        System.Console.WriteLine("Число должно быть положительным");
        return false;
    }
    return true;
}
int AkkermanFunction (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}

void Execute()
{
    int m = PromptInt("Введите число M: ");
    if (ValidateNumber(m))
    {
        int n = PromptInt("Введите число N: ");
        if (ValidateNumber(n))
        {
            AkkermanFunction(m, n);
            Console.Write(AkkermanFunction(m, n));
        }
    }
    
}

Execute();
