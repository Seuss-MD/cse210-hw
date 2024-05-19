using System;
using System.Threading;

abstract class Activity
{
    private string name;
    private string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start(int duration)
    {
        Console.WriteLine($"\nStarting {name} Activity:");
        Console.WriteLine(description);
        Console.WriteLine($"Activity Duration: {duration} seconds");
        Countdown(3);
        ExecuteActivity(duration);
        Finish();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }
    }

    public abstract void ExecuteActivity(int duration);

    private void Finish()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You've finished the {name} activity.");
    }
}