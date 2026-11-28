using System;

namespace HW01_Стихотворение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPoem();
        }

        static void PrintPoem()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Михаил Лермонтов");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Парус");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Белеет парус одинокой");
            Console.WriteLine("В тумане моря голубом!..");
            Console.WriteLine("Что ищет он в стране далёкой?");
            Console.WriteLine("Что кинул он в краю родном?..");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Играют волны — ветер свищет,");
            Console.WriteLine("И мачта гнётся и скрыпит...");
            Console.WriteLine("Увы! он счастия не ищет");
            Console.WriteLine("И не от счастия бежит!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Под ним струя светлей лазури,");
            Console.WriteLine("Над ним луч солнца золотой...");
            Console.WriteLine("А он, мятежный, просит бури,");
            Console.WriteLine("Как будто в бурях есть покой!");

            Console.ForegroundColor = defaultColor;
        }
    }
}
