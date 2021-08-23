using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Please type a number");
            try
            {
                num1 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please type a 2nd number");
            try
            {
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please type the operation you would like applied");
            string Operator = Console.ReadLine();
            while (true)
            {
                if (Operator == "+")
                {
                    Console.WriteLine(num1 + num2);
                    break;
                }
                else if (Operator == "-")
                {
                    Console.WriteLine(num1 - num2);
                    break;
                }
                else if (Operator == "/")
                {
                    Console.WriteLine(num1 / num2);
                    break;
                }
                else if (Operator == "*")
                {
                    Console.WriteLine(num1 * num2);
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, we do not yet support that operation. Please enter one of the following: +, -, *, or /");
                    Operator = Console.ReadLine();
                }
            }
        }
    }
}
