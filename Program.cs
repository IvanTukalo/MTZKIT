using System;
using System.Text;

class Program
{
    static int CalcCNonRec(int m, int n)
    {
        // Виклик функції для обчислення факторіалу да апчхі
        int numerator = CalcFactorial(m);

        // Виклик функції для обчислення факторіалу
        int denominator = CalcFactorial(n) * CalcFactorial(m - n);

        // Розрахунок біноміального коефіцієнту
        int result = numerator / denominator;

        return result;
    }

    static int CalcFactorial(int num)
    {
        if (num == 0 || num == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }

    static int CalcCRec(int m, int n)
    {
        if (m <= 1 || n == 0 || n == m)
            return 1;

        // Рекурсивний виклик функції
        return CalcCRec(m - 1, n - 1) + CalcCRec(m - 1, n);
    }
    static void DoBlock_1()
    {
        // Виклик рекурсивної функції
        Console.WriteLine("Введіть m та n для C(m, n):");
        Console.Write("Введіть m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть n: ");
        int n = Convert.ToInt32(Console.ReadLine()); 
        int resultRec = CalcCRec(m, n);
        Console.WriteLine($"C(m, n) з використанням рекурсивного методу: {resultRec}");
    }
    static void DoBlock_2()
    {
        // Виклик нерекурсивної функції
        Console.WriteLine("Введіть m та n для C(m, n):");
        Console.Write("Введіть m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int resultNonRec = CalcCNonRec(m, n);
        Console.WriteLine($"C(m, n) з використанням нерекурсивного методу: {resultNonRec}");
    }
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        int choice;
        do
        {
            Console.WriteLine("Для виконання блоку 1 (Рекурсивна функція) введіть 1");
            Console.WriteLine("Для виконання блоку 2 (Нерекурсивна функція) введіть 2");
            Console.WriteLine("Для виходу з програми введіть 0");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Виконую блок 1");
                    DoBlock_1();
                    break;
                case 2:
                    Console.WriteLine("Виконую блок 2");
                    DoBlock_2();
                    break;
                case 0:
                    Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 0.", choice);
                    break;
            }
        } while (choice != 0);
    }
}
