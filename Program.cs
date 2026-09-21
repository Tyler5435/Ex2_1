namespace Ex2_1 // This is a simple program that demonstrates the order of execution of lines of code in C#.
{
    internal class Program // The Main method is the entry point of the program. It is executed first when the program is run.
    {
        static void Main(string[] args) // The Main method is the entry point of the program. It is executed first when the program is run.
        {
            Console.WriteLine("This is the first line of the program. It will be executed first.");  //           
            Console.ReadKey();  // This line of code will pause the program until the user presses a key. It allows the user to see the output of the previous line before continuing.
            Console.ForegroundColor = ConsoleColor.Red; // This line of code changes the colour of the text in the console to red. It will affect all subsequent lines of code that write to the console.
            Console.WriteLine("But then the colour changes to Red."); // This line of code will be executed after the previous line, and it will be displayed in red text.
            Console.ReadKey();// This line of code will pause the program until the user presses a key. It allows the user to see the output of the previous line before continuing.
            Console.BackgroundColor = ConsoleColor.White; // This line of code changes the background colour of the console to white. It will affect all subsequent lines of code that write to the console.
            Console.WriteLine("And the background goes white"); // This line of code will be executed after the previous line, and it will be displayed with a white background.
            Console.ReadKey(); //   This line of code will pause the program until the user presses a key. It allows the user to see the output of the previous line before continuing.
            Console.ResetColor(); // This line of code resets the console colours to their default values. It will affect all subsequent lines of code that write to the console.
            Console.WriteLine("But it's okay. We can reset it"); // This line of code will be executed after the previous line, and it will be displayed with the default console colours.
            Console.ReadKey(); // This line of code will pause the program until the user presses a key. It allows the user to see the output of the previous line before continuing.
            Console.ForegroundColor = ConsoleColor.Yellow; //   This line of code changes the colour of the text in the console to yellow. It will affect all subsequent lines of code that write to the console.
            Console.WriteLine("The order of lines of code is important"); // This line of code will be executed after the previous line, and it will be displayed in yellow text.
            Console.WriteLine("We start at the top and work down"); // This line of code will be executed after the previous line, and it will be displayed in yellow text.
            Console.ReadKey(); // This line of code will pause the program until the user presses a key. It allows the user to see the output of the previous line before continuing.
        }
    }
}
