using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = 0;

                Console.Write("Enter a Number: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a Number: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Choose an operator: \n Add: + \n Multiply: x \n Divide: / \nEnter: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "x":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        result = firstNum - secondNum;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                        
                }
                Console.Write($"Results: {result}\nPress Enter to exit");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input. Must be a number: {e}");
            }
        }
    }
}
