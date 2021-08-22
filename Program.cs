using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number");
            var num1 = Console.ReadLine();
            Console.WriteLine("Please type another number");
            var num2 = Console.ReadLine();
            Console.WriteLine($"The numbers you have typed are {num1} and {num2} ");
            Console.WriteLine("Please type the function you would like applied");
            var Operator = Console.ReadLine();
            Console.WriteLine($"The function you would like applied is {Operator}");
        }
    }
}
