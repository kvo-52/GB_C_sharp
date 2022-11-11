// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int ValidateMessage (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FirstNumber(int a)
{
    int result = ((a / 10000) % 10);
    return result;
}
int SecondNumber(int a)
{
    int result = ((a / 1000) % 10);
    return result;
}
int FourthNumber(int a)
{
    int result = ((a / 10) % 10);
    return result;
}
int FifthtNumber(int a)
{
    int result = ((a / 1) % 10);
    return result;
}


int value= ValidateMessage("Введите пятизначное число: ");
int firstvalue= FirstNumber(value);
int secondtvalue= SecondNumber(value);
int fourthvalue= FourthNumber(value);
int fifthvalue= FifthtNumber(value);

if (value>9999 && value<100000)
{
    if (firstvalue==fifthvalue && secondtvalue==fourthvalue)
{
   Console.WriteLine($"Число {value} является полиндромом");
}
else
{
    Console.WriteLine($"Число {value} не является полиндромом");
}  
}
else
{
 Console.WriteLine("НЕВЕРНО! Необходимо ввести пятизначное число.");   
}


