// Задача 4: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int ValidateMessage (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber (int number)
{
    if (number<1)
    {
        System.Console.WriteLine("Необходимо ввести натуральное число.");
        return false;
    }
    if (number==1)
    {
        System.Console.WriteLine("Четные числа в интервале отсутствуют.");
        return false;
    }
    return true;
}

int value= ValidateMessage ("Введите натульное число:");
int number=2;

if (ValidateNumber(value))
{
while (value>=number)
{
    System.Console.Write($"{number} ");
   number=number+2;
}
}
