namespace HW02_Вычисление_заданных_величин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону треугольника: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону треугольника: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Введите угол между сторонами в градусах: ");
            double angle = double.Parse(Console.ReadLine());

            double area = GetArea(sideA, sideB, angle);
            double perimeter = GetPerimeter(sideA, sideB, angle);

            Console.WriteLine($"Площадь треугольника: {area:F3}");
            Console.WriteLine($"Периметр треугольника: {perimeter:F3}");
        }

        static double GetRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        static double GetThirdSide(double sideA, double sideB, double angle)
        {
            double radians = GetRadians(angle);
            return Math.Sqrt(sideA * sideA + sideB * sideB - 2 * sideA * sideB * Math.Cos(radians));
        }

        static double GetArea(double sideA, double sideB, double angle)
        {
            return 0.5 * sideA * sideB * Math.Sin(GetRadians(angle));
        }

        static double GetPerimeter(double sideA, double sideB, double angle)
        {
            return sideA + sideB + GetThirdSide(sideA, sideB, angle);
        }
    }
}
