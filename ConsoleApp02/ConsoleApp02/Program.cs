using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("----------------- Luke's BMI Calculator -----------------");
        Console.WriteLine("-----------------  Student ID 22206266 ------------------");
        Console.WriteLine("-------------- Buckinghamhshire University --------------");
        Console.WriteLine("---------------------------------------------------------");

        Console.Write("let's calculate your BMI.");
        Console.Write("Enter your weight (KG): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height (Meters): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMI = weight / (height * height);
        Console.WriteLine($"Your BMI is {BMI:F2}");

        if (BMI < 18.5)
            Console.WriteLine($"Your BMI of {BMI:F2} classes as underweight for you");
        else if (BMI >= 18.5 && BMI <= 24.9)
            Console.WriteLine($"Your BMI of {BMI:F2} classes as a healthy weight");
        else if (BMI >= 25 && BMI <= 29.9)
            Console.WriteLine($"Your BMI of {BMI:F2} classes as overweightt");
        else
            Console.WriteLine($"Your BMI of {BMI:F2} classes as obese");


  

    }
}
