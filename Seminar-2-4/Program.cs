// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int numberDay = ValidateMessage("Введите число от 1 до 7: ");
int day= numberDay;


if (day==6 || day==7)
{
 Console.WriteLine("Да. Выходной день");   
}
if (day>0 && day<6)
{
   Console.WriteLine("Нет. Будний день");
}
if (day>7 || day<0)
{
   Console.WriteLine("Такого дня недели нет"); 
}


int ValidateMessage (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}