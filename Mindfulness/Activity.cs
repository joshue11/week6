using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;
    private SpinnerAnimation _spinner = new SpinnerAnimation();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        _spinner.Run(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGreat job!");
        _spinner.Run(2);

        Console.WriteLine($"\nYou completed '{_name}' for {_duration} seconds.");
        _spinner.Run(3);
    }

    public int GetDuration()
    {
        return _duration;
    }
}
