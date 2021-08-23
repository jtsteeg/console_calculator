using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please type a number");
            try
            {
                int num1 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please type a 2nd number");
            try
            {
                int num2 = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine($"you can't do that! {ex}");
                System.Environment.Exit(0);
            }

            //bool isnumber = int.TryParse(Console.ReadLine(), out num1);
            // Console.WriteLine("Please type another number");
            //int num2 = Console.ReadLine();
            //Console.WriteLine("Please type the operation you would like applied");
            //string Operator = Console.ReadLine();

        }
    }
}
