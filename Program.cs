using System.Drawing;

namespace Ex2_1 // This is a simple program that demonstrates the order of execution of lines of code in C#.
{
    internal class Program // The Main method is the entry point of the program. It is executed first when the program is run.
    {
        static void Main(string[] args) // The Main method is the entry point of the program. It is executed first when the program is run.
        {
            // The following line of code changes the color of the console text to red.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Color is Red");
            Console.Read();
            
            // The following line of code changes the color of the console text to Amber.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Color is Amber");
            Console.ReadKey();

            // The following line of code adds a blank line to the console output for better readability.g
            Console.WriteLine("");

            // The following line of code changes the color of the console text to Green.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Color is Green");
            Console.ReadKey();

            // The following line of code resets the color of the console text to the default color.
            Console.ResetColor();

        } // The Main method ends here, and the program will exit after the last line of code is executed.
    }
}
