using System;

class UnitConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Unit Converter ===\n");
        Console.WriteLine("1. Kilometers to Miles");
        Console.WriteLine("2. Miles to Kilometers\n");
        Console.Write("Choose an option (1 or 2): ");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine();

        double result = 0.0;

        if (choice == 1)
        {
            Console.Write("Enter distance in kilometers: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = km * 0.621371;
            Console.WriteLine($"{km} km is {result:F2} miles.\n");
        }
        else if (choice == 2)
        {
            Console.Write("Enter distance in miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = miles / 0.621371;
            Console.WriteLine($"{miles} miles is {result:F2} kilometers.\n");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.WriteLine("Done. Press any key to exit.");
        Console.ReadKey();

    }
}
