using System;

class Program
{
    static void Main()
    {
        // Welcome message - Display the initial greeting to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight and convert input to double
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight exceeds the maximum allowed weight of 50
        if (weight > 50)
        {
            // Display error message and exit the program if weight is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt the user for the package width and convert input to double
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package height and convert input to double
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package length and convert input to double
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum of all three dimensions (width + height + length)
        double dimensionsTotal = width + height + length;

        // Check if the total dimensions exceed the maximum allowed total of 50
        if (dimensionsTotal > 50)
        {
            // Display error message and exit the program if dimensions are too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the shipping quote:
        // Multiply width, height, and length together to get the volume
        // Then multiply by weight
        // Finally divide by 100 to get the quote amount
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote formatted as a dollar amount with 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Display thank you message
        Console.WriteLine("Thank you!");
    }
}

