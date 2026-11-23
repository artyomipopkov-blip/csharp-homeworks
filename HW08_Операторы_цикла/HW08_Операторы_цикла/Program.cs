using System;

namespace HW08_Операторы_цикла
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Произведение чисел от m до n");
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            long product = GetProduct(m, n);
            Console.WriteLine($"Произведение чисел от {m} до {n} равно {product}");

            Console.WriteLine();
            Console.WriteLine("Задача 2. Единица с наибольшим средним населением пункта");
            Console.Write("Введите количество административных единиц: ");
            int unitsCount = int.Parse(Console.ReadLine());
            int bestNumber = 0;
            double bestAverage = 0;
            for (int i = 1; i <= unitsCount; i++)
            {
                Console.Write($"Жители {i}-й единицы (тыс. человек): ");
                int residents = int.Parse(Console.ReadLine());
                Console.Write($"Количество населённых пунктов {i}-й единицы: ");
                int settlements = int.Parse(Console.ReadLine());
                double average = GetUnitAverage(residents, settlements);
                if (i == 1 || average > bestAverage)
                {
                    bestAverage = average;
                    bestNumber = i;
                }
            }
            Console.WriteLine($"Административная единица {bestNumber}: {bestAverage:F3} тыс. человек на населённый пункт");

            Console.WriteLine();
            Console.WriteLine("Задача 3. Члены последовательности, не меньшие a");
            Console.Write("Введите a (1 < a <= 2): ");
            double a = double.Parse(Console.ReadLine());
            PrintSequenceTerms(a);

            Console.WriteLine();
            Console.WriteLine("Задача 4. Сколько раз цифра k встречается в числе");
            Console.Write("Введите натуральное число: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Введите цифру k: ");
            int k = int.Parse(Console.ReadLine());
            int count = CountDigit(number, k);
            Console.WriteLine($"Количество вхождений цифры {k}: {count}");

            Console.WriteLine();
            Console.WriteLine("Задача 5. Перестановка цифр с конца в начало");
            Console.Write("Введите натуральное число: ");
            long source = long.Parse(Console.ReadLine());
            long reversed = ReverseNumber(source);
            Console.WriteLine($"Перевёрнутое число: {reversed}");

            Console.WriteLine();
            Console.WriteLine("Задача 6. Первые n простых чисел");
            Console.Write("Введите n: ");
            int primesCount = int.Parse(Console.ReadLine());
            PrintFirstPrimes(primesCount);
        }

        static long GetProduct(int m, int n)
        {
            long product = 1;
            for (int i = m; i <= n; i++)
            {
                product *= i;
            }
            return product;
        }

        static double GetUnitAverage(int residents, int settlements)
        {
            return residents / (double)settlements;
        }

        static void PrintSequenceTerms(double a)
        {
            int number = 1;
            double value = 1 + 1 / Math.Sqrt(number);
            while (value >= a)
            {
                if (number > 1)
                {
                    Console.Write("; ");
                }
                Console.Write($"1 + 1/√{number}");
                number++;
                value = 1 + 1 / Math.Sqrt(number);
            }
            Console.WriteLine();
        }

        static int CountDigit(long number, int digit)
        {
            int count = 0;
            while (number > 0)
            {
                if (number % 10 == digit)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }

        static long ReverseNumber(long number)
        {
            long result = 0;
            while (number > 0)
            {
                long digit = number % 10;
                result = result * 10 + digit;
                number /= 10;
            }
            return result;
        }

        static void PrintFirstPrimes(int count)
        {
            int found = 0;
            int candidate = 2;
            while (found < count)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor * divisor <= candidate; divisor++)
                {
                    if (candidate % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    if (found > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(candidate);
                    found++;
                }
                candidate++;
            }
            Console.WriteLine();
        }
    }
}
