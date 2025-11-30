using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What blessings have you seen this month?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list positive things in your life.") { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nYou have a few seconds to prepare...");
        Countdown(5);

        int elapsed = 0;
        List<string> items = new List<string>();

        Console.WriteLine("\nStart listing items:");

        while (elapsed < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 2;
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        End();
    }
}
