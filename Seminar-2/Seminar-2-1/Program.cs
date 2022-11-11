// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int ValidateMessage (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber (int number)
{
    if (number<100 || number>1000)
    {
        System.Console.WriteLine("НЕВЕРНО! Необходимо ввести трехзначное число.");
        return false;
    }
    return true;
}

int SecondNumber(int a)
{
    int result = ((a / 10) % 10);
    return result;
}

int value= ValidateMessage("Введите трехзначное число: ");

if (ValidateNumber(value))
{
   value= SecondNumber(value);
   Console.WriteLine($"Вторая цифра: {value}");
}
else
{
    Console.WriteLine("Попробуйте еще раз");
}
