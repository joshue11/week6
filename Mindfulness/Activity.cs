using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} ===\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGreat job!");
        Spinner(3);
        Console.WriteLine($"\nYou completed the {_name} activity for {_duration} seconds!");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(symbols[index]);
            Thread.Sleep(150);
            Console.Write("\b \b");
            index = (index + 1) % symbols.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
