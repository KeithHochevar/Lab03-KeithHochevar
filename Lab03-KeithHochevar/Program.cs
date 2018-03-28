using System;

namespace Lab03_KeithHochevar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;

            Console.Write("Enter number 1: ");

            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");

            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"{sum}");


            int x;
            int y;
            int z;

            x = 1;
            y = 2;
            z = 4;

            Console.WriteLine($"{(x + y) * (z + 10)}");


            Console.WriteLine("Hello\tWorld!");

            Console.WriteLine("Hello\nWorld");

            Console.WriteLine("\"Hello World!\"");

            Console.WriteLine("Hello\\World!");
        }
    }
}
