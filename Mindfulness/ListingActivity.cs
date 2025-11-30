using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "What blessings have you noticed recently?"
    };

    public ListingActivity() 
        : base("Listing Activity",
              "This activity helps you think of positive things by listing items.") {}

    public void RunListing()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        
        Console.WriteLine("\nYou have 5 seconds before listing begins...");
        new SpinnerAnimation().Run(5);

        List<string> items = new List<string>();
        int duration = GetDuration();
        int elapsed = 0;

        Console.WriteLine("\nStart listing items. Press Enter after each:");

        while (elapsed < duration)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                items.Add(entry);
            }

            System.Threading.Thread.Sleep(1000);
            elapsed++;
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndActivity();
    }
}
