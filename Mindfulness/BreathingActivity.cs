using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
              "This activity will help you relax by pacing your breathing. Clear your mind and focus.") {}

    public void RunBreathing()
    {
        StartActivity();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);

            Console.Write("Breathe out... ");
            Countdown(6);

            elapsed += 10;
        }

        EndActivity();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }
}
