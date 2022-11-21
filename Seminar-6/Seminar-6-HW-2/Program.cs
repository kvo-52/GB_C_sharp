// Задача 2: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int K = 0;
const int B = 1;
const int x = 0;
const int y = 1;

double Prompt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine());
}

void InputCoefficient(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"Введите коэфициенты {i+1}-ого уравнения (y=k*x+b):\n");
    array[i,K]=Prompt("Введиет коэфициент K: ");
    array[i,B]=Prompt("Введиет коэфициент B: ");
}
}

double[] PointCalculation(double[,] coeff)
{
    double[] point = new double[2];
    point[x] = (coeff[1, B] - coeff[0, B]) / (coeff[0, K] - coeff[1, K]);
    point[y] = point[0] * coeff[0, 0] + coeff[0, 1];
    return point;
}

double[,] coefficirnt = new double[2, 2];

InputCoefficient(coefficirnt);
double[] crossPoint = PointCalculation(coefficirnt);
Console.WriteLine();
Console.Write($"Точка пересечения прямых: ({crossPoint[x]},{crossPoint[y]})");