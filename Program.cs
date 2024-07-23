using System;


namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //Changes console text to green.
            Console.WriteLine("How many spots do you need?"); //Writes line of text to screen.
            int result = Convert.ToInt32(Console.ReadLine()); //Converts the user's text (for example, if they need 4 spots then 4), to an int, so it can be used for an array.
            string[] names = new string[result]; //Creates new string array.

            Console.WriteLine("What are your choice's names?");

            for (int i = 0; i < names.Length; i++) //For loop, takes the name's the user wrote.
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere are their names alphabetically:");
            Array.Sort(names); //Sorts the names alphabetically
            for (int i = 0; i < names.Length; i++) //For loop, prints the name's the user wrote alphabetically.
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}




