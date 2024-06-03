using System;

class Program
{
    static void Main(string[] args)
    {
        const double BaseRate = 200; 
        const double HourlyRate = 150; 
        const double PerMileRate = 2;
      
        Console.Write("Enter the estimated number of hours: ");
        double hours = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the estimated number of miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double totalFee = BaseRate + (HourlyRate * hours) + (PerMileRate * miles);

        Console.WriteLine($"Total Moving Fee: ${totalFee}");
    }
}

