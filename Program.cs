using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to the main menu!");

        bool looping = true;
        while (looping)
        {
            Console.WriteLine("------");
            Console.WriteLine("Press 0 to exit program");
            Console.WriteLine("Press 1 to get movie ticket price");
            Console.WriteLine("Press 3 to enter the timeloop");
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
                case 1:
                    Console.WriteLine("Entering movie price realm.");
                    MovieGoers();
                    break;
                case 3:
                    Console.WriteLine("Entering the timeloop.");
                    Timeloop();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    public static void MovieGoers()
    {
        Console.WriteLine("Enter amount of moviegoers:");
        string enteredInput = Console.ReadLine();
        int moviegoers = 0;
        int.TryParse(enteredInput, out moviegoers);
        int totalTickerCost = 0;
        for (int i = 0; i < moviegoers; i++)
        {
            totalTickerCost += MoviePrice();
        }
        Console.WriteLine(moviegoers + " moviegoers. \nTotal cost is " +  totalTickerCost + "kr");
    }

    public static int MoviePrice()
    {
        int youthPrice = 80;
        int seniorPrice = 90;
        int adultPrice = 120;

        Console.WriteLine("Enter age:");
        string enteredInput = Console.ReadLine();
        int input = 0;
        int.TryParse(enteredInput, out input);

        if (input < 20)
        {
            Console.WriteLine("Movie price for youths is :: " + youthPrice + "kr");
            return youthPrice;
        }
        else if (input > 64)
        {
            Console.WriteLine("Movie price for seniors is :: " + seniorPrice + "kr");
            return seniorPrice;
        }
        else
        {
            Console.WriteLine("Movie price for adults is : " + adultPrice + "kr");
            return adultPrice;
        }
    }

    public static void Timeloop()
    {
        Console.WriteLine("Enter a word to timeloop:");
        string enteredInput = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + ". " + enteredInput + " ");
        }
        Console.WriteLine("Exited the timeloop:");
    }
}