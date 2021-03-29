using System;

namespace CodeTestExpleo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal för kalkylatorn level 1: ");
            string input1 = Console.ReadLine();
            Console.WriteLine(Calculator.CalculatorLevel1(input1));

            Console.Write("Skriv in ett tal för kalkylatorn level 2: ");
            string input2 = Console.ReadLine();
            Console.WriteLine(Calculator.CalculatorLevel2(input2));

        }
    }
}
