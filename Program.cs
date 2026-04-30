using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("Press 2 to get movie ticket price for a group");
            Console.WriteLine("Press 3 to enter the timeloop");
            Console.WriteLine("Press 4 to split the string (of fate)");
            Console.WriteLine("Enter input:");

            string enteredInput = Console.ReadLine();
            int input = 0;
            bool valid = int.TryParse(enteredInput, out input);

            if (!valid)
            {
                input = 9;
            }
            switch (input)
            {
                case 0:
                    Console.WriteLine("Closing program");
                    looping = false;
                    break;
                case 1:
                    Console.WriteLine("Entering movie price realm.");
                    MoviePrice();
                    break;
                case 2:
                    Console.WriteLine("Entering movie price realm.");
                    MovieGoers();
                    break;
                case 3:
                    Console.WriteLine("Entering the timeloop.");
                    Timeloop();
                    break;
                case 4:
                    Console.WriteLine("Splitting the words.");
                    SplitString();
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
        bool valid = int.TryParse(enteredInput, out moviegoers);
        if (!valid)
        {
            Console.WriteLine("Invalid amount. Try again later");
            return;
        }

        int totalTicketCost = 0;
        for (int i = 0; i < moviegoers; i++)
        {
            totalTicketCost += MoviePrice();
        }
        Console.WriteLine(moviegoers + " moviegoers. \nTotal cost is " +  totalTicketCost + "kr");
    }

    public static int MoviePrice()
    {
        int freePrice = 0;
        int youthPrice = 80;
        int seniorPrice = 90;
        int adultPrice = 120;

        Console.WriteLine("Enter age:");
        string enteredInput = Console.ReadLine();
        int input = 0;
        bool valid = int.TryParse(enteredInput, out input);

        if (!valid)
        {
            Console.WriteLine("Invalid input. Getting standard price");
            return adultPrice;
        }

        if (input < 20)
        {
            if (input < 5)
            {
                Console.WriteLine("Kids can watch for free!");
                return freePrice;
            }
            Console.WriteLine("Movie price for youths is " + youthPrice + "kr");
            return youthPrice;
        }
        else if (input > 64)
        {
            if (input > 100)
            {
                Console.WriteLine("Ancients can watch for free!");
                return freePrice;
            }
            Console.WriteLine("Movie price for seniors is " + seniorPrice + "kr");
            return seniorPrice;
        }
        else
        {
            Console.WriteLine("Movie price for adults is " + adultPrice + "kr");
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
        Console.WriteLine("\nExited the timeloop:");
    }

    public static void SplitString()
    {
        Console.WriteLine("Write a sentance with a least three words:");
        string enteredInput = Console.ReadLine();
        char space = ' ';
        int spaces = enteredInput.Count(letter => letter == space);
        if (spaces < 2)
        {
            Console.WriteLine("Insufficient spaces!");
            return;
        }
        var splitString = enteredInput.Split(space);

        string thirdWord = splitString[2];
        Console.WriteLine("The third word is: " + thirdWord);
    }
}