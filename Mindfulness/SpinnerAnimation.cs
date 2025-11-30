using System;
using System.Threading;

public class SpinnerAnimation
{
    public void Run(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 5; i++)
        {
            Console.Write(frames[i % 4]);
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }
}
