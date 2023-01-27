// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значение точки b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
double x = (b2-b1)/(k1-k2);
Console.WriteLine($"Х равен {x}");
double y =  k2 * x + b2;
Console.WriteLine($"Y равен {y}");
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}