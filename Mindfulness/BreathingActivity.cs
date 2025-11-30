using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
               "This activity helps you relax through breathing exercises.") { }

    public void Run()
    {
        Start();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("\nBreathe out... ");
            Countdown(4);
            elapsed += 4;
        }

        End();
    }
}
