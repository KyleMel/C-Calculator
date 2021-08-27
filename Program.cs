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

                Console.Write("Enter first number: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second number: ");
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
                        result = firstNum / secondNum;
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

/*
   PROJECT OBJECTIVES
    Console App [x]
    Manage via Git/Hub [x]
    Demonstrate branch [x]
    Min of 6 commits [x]
    Follow conventions to best of my ability [x]
    Validate uer input via catch [x]
*/
