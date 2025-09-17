using System;
class Program
{
    static void Main(string[] args)
    {
        // Validera enhetssystemet
        string unit;
        while (true)
        {
            Console.WriteLine("BMI Calculator! Select metric or imperial (m/i):");
            unit = Console.ReadLine()!.ToLower();

            if (unit == "metric" || unit == "m" || unit == "imperial" || unit == "i")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid unit. Please enter 'm' or 'i'.");
            }
        }

        // Validera vikt
        double weight;
        while (true)
        {
            Console.WriteLine("Enter weight:");
            if (double.TryParse(Console.ReadLine(), out weight) &&  0 < weight)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid weight. Please enter a valid positive number.");
            }
        }

        // Validera längd
        double height;
        while (true)
        {
            Console.WriteLine("Enter height:");
            if (double.TryParse(Console.ReadLine(), out height) && 0 < height)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid height. Please enter a valid positive number.");
            }
        }

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
        // Beräkna BMI baserat på enhetssystemet
        if (unit == "metric" || unit == "m")
        {
            // Metric
            return weight / (height * height);
        }
        else
        {
            //Imperial
            return 703 * (weight / (height * height));
        }

    }
}