using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Please enter a number"); 
            try
            {
                num1 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Please enter a 2nd number");
            try
            {
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Please enter the operation you would like performed: +, -, *, /");
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
                    if (num2 == 0)
                    {
                        Console.WriteLine("you can't divide by zero!");
                        System.Environment.Exit(1);
                    }
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
