using System;

class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("BMI Calculator! Select meteric or imperial(m/i):");
        string unit = Console.ReadLine()!.ToLower();

        Console.WriteLine("Enter weight:");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Standardanrop med default enhet (metric)
        double bmi1 = CalculateBMI(weight, height);
        Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

        // Namngivna argument i annan ordning
        double bmi2 = CalculateBMI(height: height, weight: weight);
        Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

        // Namngivna argument + explicit enhet
        double bmi3 = CalculateBMI(unit: unit, weight: weight, height: height);
        Console.WriteLine($"BMI (imperial): {bmi3:F2}");
    }


    static double CalculateBMI(double weight, double height, string unit = "metric")
    {
        // Example usage of the new C# 13.0 feature: Primary Constructors for non-record classes
        if (unit == "metric" || unit == "m")
        {
            return weight / (height * height);
        }
        else if (unit == "imperial" || unit == "i")
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