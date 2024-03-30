using System;

class Program
{
    static void Main()
    {
        // Вводим координаты трех точек
        Console.WriteLine("Введите координаты первой точки (x1 y1): ");
        string[] input1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(input1[0]);
        double y1 = double.Parse(input1[1]);

        Console.WriteLine("Введите координаты второй точки (x2 y2): ");
        string[] input2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(input2[0]);
        double y2 = double.Parse(input2[1]);

        Console.WriteLine("Введите координаты третьей точки (x3 y3): ");
        string[] input3 = Console.ReadLine().Split(' ');
        double x3 = double.Parse(input3[0]);
        double y3 = double.Parse(input3[1]);

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