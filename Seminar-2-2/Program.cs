// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int Number = new Random().Next(100, 1000);
int NewNumber = 0;

NumberWithoutSecond();
System.Console.WriteLine();
System.Console.WriteLine($"Случайное трехзначное число {Number}");
System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
System.Console.WriteLine();

int NumberWithoutSecond()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}