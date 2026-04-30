using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to the main menu!");

        bool looping = true;
        while (looping)
        {
            Console.WriteLine("------");
            Console.WriteLine("Enter input:");
            string enteredInput = Console.ReadLine();
            int input = 0;
            int.TryParse(enteredInput, out input);
            switch (input)
            {
                case 0:
                    Console.WriteLine("Closing program");
                    looping = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}