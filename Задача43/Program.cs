// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine()!);

pointOfIntersection(b1, k1, b2, k2);

void pointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;

    if ((k1 * point[0] + b1) == (k2 * point[0] + b2))
    {
        Console.Write("Point of intersection: ");
        Console.Write($"[{String.Join(", ", point)}]");
    }
    else
    {
        Console.WriteLine("There is no intersection.");
    }
}
