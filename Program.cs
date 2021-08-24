using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose an operator: \n Add: + \n Multiply: x \n Divide: / \nEnter: ");
            Console.ReadLine();

            Console.Write("Results: \n Press Enter to exit");
            Console.ReadLine();

        }
    }
}
