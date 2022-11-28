// Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int Exp(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * Exp(a, (b - 1));
}
int a = 2;
int b = 6;
Console.WriteLine(Exp(a, b));

// int CustomPower(int intBase, int intPower) // Вариант решения 2 - ?
// {
//     if (intPower == 0) return 1; // Частный случай для степени 0
//     if (IsNegative(intPower)) intPower *= -1;
//     if (IsEven(intPower))
//     {
//         int Result = CustomPower(intBase, intPower/2);
//         return Result * Result;
//     }
//     else return intBase * CustomPower(intBase, intPower-1);
// }

// Варинат решения 3

// int Prompt(string msg)
// {
//     Console.WriteLine(msg);
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     return userInput;
// }

// int Exp(int a, int b)
// {
//     if (b == 0) return 1;
//     else if (b % 2 == 0) return Exp(a * a, b / 2);
//     else return Exp(a, b - 1) * a;

// }
// int a = 2;
// int b = 6;
// Console.WriteLine(Exp(a, b));

