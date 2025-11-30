using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "What did you learn from it?",
        "How did you feel afterward?",
        "What made this experience unique?",
        "How can you apply this learning?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on moments of strength and growth.") {}

    public void RunReflection()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nReflect on the following questions:");

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            string q = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n→ " + q);
            new SpinnerAnimation().Run(4);

            elapsed += 4;
        }

        EndActivity();
    }
}
