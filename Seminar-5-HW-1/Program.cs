// Задача 1: Напишите цикл, который принимает на вход два числа
//  (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

// bool ValidateNumber(int number)
// {
//     if ( number<=0)
//     {
//         System.Console.WriteLine("Число должно быть больше нуля");
//         return false;
//     }
//     return true;
// }

int IntPow(int x, int pow)
{
    int ret = 1;
    while ( pow != 0 )
    {
        if ( (pow & 1) == 1 )
            ret *= x;
        x *= x;
        pow >>= 1;
    }
    return ret;
}

int numberA = Prompt("Введите первое число: ");
int numberB = Prompt("Введите второе число: ");
// if (ValidateNumber(numberB))
// {
    int pow =IntPow(numberA, numberB);
    System.Console.WriteLine($"Результат возвдения  числа {numberA} в степень {numberB} = {pow}");
// }