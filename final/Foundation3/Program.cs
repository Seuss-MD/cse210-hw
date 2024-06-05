using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Clear();
    Lectures lec = new Lectures("John Smith", 50, "Restoration", "The basis of Restoration", "07/22/2023", "8:30 p.m");
    lec.SetAddress("5th Street", "Albany", "New York", "USA");
    Console.WriteLine($"\n{lec.GetStandardDetails()}");
    Console.WriteLine($"\n{lec.GetShortDescription()}");
    lec.GetFullInformation();

    Receptions rec = new Receptions("myevil300@gmail.com", "Gospel", "The Jesus Christ Teachings", "08/12/2023", "04:00 p.m");
    rec.SetAddress("Downing Street", "London", "London", "UK");
    Console.WriteLine($"\n{rec.GetStandardDetails()}");
    Console.WriteLine($"\n{rec.GetShortDescription()}");
    rec.GetFullInformation();   

    Outdoor outdoor = new Outdoor("Sunny", "BYU weekly gathering", "Course210 Team Activity", "09/13/2023", "10:00 a.m");
    outdoor.SetAddress("Oliveira Street", "Recife", "Pernambuco", "Brazil");
    Console.WriteLine($"\n{outdoor.GetStandardDetails()}");
    Console.WriteLine($"\n{outdoor.GetShortDescription()}");
    outdoor.GetFullInformation(); 

    }
}