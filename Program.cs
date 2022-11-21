using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Console Calculator");
            Console.WriteLine("1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Exit\nChoose an operation:");

            short choose = short.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Input a number: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type another value: ");
            float value2 = float.Parse(Console.ReadLine());

            float result = value1 + value2;
            Console.WriteLine($"The result of this sum is {result}.");

            Console.ReadKey();
            Menu();
        }

        static void Sub()
        {
            Console.Clear();

            Console.WriteLine("Input a number: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type another value: ");
            float value2 = float.Parse(Console.ReadLine());

            float result = value1 - value2;
            Console.WriteLine($"The result of this difference is {result}.");

            Console.ReadKey();
            Menu();
        }

        static void Mult()
        {
            Console.Clear();

            Console.WriteLine("Input a number: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type another value: ");
            float value2 = float.Parse(Console.ReadLine());

            float result = value1 * value2;
            Console.WriteLine($"The result of this multiplication is {result}.");

            Console.ReadKey();
            Menu();
        }

        static void Div()
        {
            Console.Clear();

            Console.WriteLine("Input a number: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type another value: ");
            float value2 = float.Parse(Console.ReadLine());

            float result = value1 / value2;
            Console.WriteLine($"The result of this division is {result}.");

            Console.ReadKey();
            Menu();
        }
    }
}
