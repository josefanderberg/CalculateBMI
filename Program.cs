using System;

class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("BMI Calculator! Select meteric or imperial");
        string unit = Console.ReadLine().ToLower();

        double bmi1 = CalculateBMI(70, 1.75);
        Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

        // Namngivna argument i annan ordning
        double bmi2 = CalculateBMI(height: 1.80, weight: 85);
        Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

        // Namngivna argument + explicit enhet
        double bmi3 = CalculateBMI(unit: "imperial", weight: 180, height: 70);
        Console.WriteLine($"BMI (imperial): {bmi3:F2}");
    }


    static double CalculateBMI(double weight, double height, string unit = "metric")
    {
        // Example usage of the new C# 13.0 feature: Primary Constructors for non-record classes
        if (uint == "metric")
        {
            return weight / (height * height);
        }
        else if (uint == "imperial")
        {
            return 703 * (weight / (height * height));
        }
        else
        {
            Console.WriteLine("Unknown unit system.");
            return -1;
        }
    }
}