// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

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
        System.Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    return true;
}

int ThirdNumber(int a)
{
    int result = (a-(((a/10) % 100)*10));
    return result;
}

int value= ValidateMessage("Введите трехзначное число: ");

if (ValidateNumber(value))
{
   value= ThirdNumber(value);
   Console.WriteLine($"Третья цифра: {value}");
}
