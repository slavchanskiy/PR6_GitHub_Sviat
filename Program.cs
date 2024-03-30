using System;

class Program
{
    static void Main()
    {
        // Задаем координаты трех точек
        double x1 = 3, y1 = 3;
        double x2 = 5, y2 = 3;
        double x3 = 4, y3 = 5;

        // Вычисляем расстояния между точками
        double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double d2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double d3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        // Проверяем, образуют ли точки равнобедренный треугольник
        if (d1 == d2 || d1 == d3 || d2 == d3)
        {
            Console.WriteLine("Точки образуют равнобедренный треугольник");
        }
        else
        {
            Console.WriteLine("Точки не образуют равнобедренный треугольник");
        }
    }
}