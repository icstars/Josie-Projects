using System;
using System.Text;
using System.Threading.Tasks;
 
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0; //Declares and initializes an integer variable to store the calculation result.
            string answer; // Are there benefits to a break line after this?
            Console.WriteLine("Hello, welcome to the calculator program");
            Console.WriteLine("Please enter your first number"); //Benefits to a break line after?
           
            num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Please enter your second number.");
           
            num2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");
           
            answer = Console.ReadLine()?.ToLower() ?? "";
 
            if (answer != null)
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
 
            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
 
            else if (answer == "m")
            {
                result = num1 * num2;
            }
 
            else if (answer == "d")
            {
                if (num2 != 0)
                {
                result = num1 / num2;
                }
 
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    Console.WriteLine("Thank you for using my calculator program!");
                    Console.Read();
                    return; // If the user chose "d", checks if the second number is not zero (to avoid division by zero). If safe, performs the division;otherwise, displays an error message and exits the method.
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");
                Console.WriteLine("Thank you for using my calculator program!");
                Console.Read();
                return;
            }
 
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using my calculator program!");
            Console.Read();
        }
    }
}
