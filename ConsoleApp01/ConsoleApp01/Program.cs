using System;
/// <summary>
/// to convert distance measurements
/// </summary>
/// <author>
/// luke lindsay 0.1
/// </author>
public class Program
{
    static void Main()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("--------------- Luke's Distance Converter ---------------");
        Console.WriteLine("-----------------  Student ID 22206266 ------------------");
        Console.WriteLine("-------------- Buckinghamhshire University --------------");
        Console.WriteLine("---------------------------------------------------------");


        Console.WriteLine("Enter Miles:");
        double MilestooFeet = Convert.ToDouble(Console.ReadLine());
        double Miles2Feet = MilestooFeet * 5280;
        if (MilestooFeet < 0)
            Console.WriteLine("error");
        



        Console.WriteLine("Enter Feet:");
        double FeettooMiles = Convert.ToDouble(Console.ReadLine());
        double Feet2Miles = FeettooMiles / 5280;
        if (FeettooMiles < 0)
            Console.WriteLine("error");


        Console.WriteLine("Enter Miles:");
        double MilestooMeters = Convert.ToDouble(Console.ReadLine());
        double Miles2Meters = MilestooMeters * 1609.34;
        if (MilestooMeters < 0)
            Console.WriteLine("error");

        Console.WriteLine("Enter Meters:");
        double MeterstooMiles = Convert.ToDouble(Console.ReadLine());
        double Meters2Miles = MeterstooMiles / 1609.34;
        if (MeterstooMiles < 0)
            Console.WriteLine("error");



    }
}
