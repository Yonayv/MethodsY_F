using System;

namespace Methods_Fixico_Yonayv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!"); // Prints a message asking for whole num
            int x = Convert.ToInt32(Console.ReadLine()); // converts the string readline
            Console.WriteLine("Please enter a whole number!");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Multiply(x, y));

            Console.WriteLine("What is your name?"); //Prints a question 
            string name = Console.ReadLine(); // Contains the variable name

            WelcomeUser(name);
            Goodbye();
        }


        // <summary>
      



        static int Multiply(int num1, int num2) 
        {
            return num1 * num2;  // <returns> num 1 and num 2
        }

        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!"); //Prints a greeting along with a username someone can print. 
        }

        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day!"); // Prints a goodbye message to the console.
        }
    }
}
