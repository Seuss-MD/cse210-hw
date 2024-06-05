using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> list = new List<Activity>();
        
        Running run = new Running(10, 2023, 7, 15, 60);
        Cycling cyc = new Cycling(25, 2023, 12, 25, 35);
        Swimming swim = new Swimming(13, 2023, 4, 17, 3);

        list.Add(run);
        list.Add(cyc);
        list.Add(swim);

        foreach (Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}