using CommonConversions.Application.Services;
using CommonConversions.Services;

class Program
{
    static void Main(string[] args)
    {
        var service = new ConversionService();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Common Conversions ===");
            Console.WriteLine("1 - Celsius to Fahrenheit");
            Console.WriteLine("2 - Kilometers to Miles");
            Console.WriteLine("3 - Kilograms to Pounds");
            Console.WriteLine("4 - Celsius to Kelvin");
            Console.WriteLine("5 - Miles to Kilometers");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            if (choice == "0") break;

            Console.Write("Enter the value to convert: ");
            if (!double.TryParse(Console.ReadLine(), out double input))
            {
                Console.WriteLine("Invalid number.");
                Console.ReadKey();
                continue;
            }

            double result = choice switch
            {
                "1" => service.CelsiusToFahrenheit(input),
                "2" => service.KilometersToMiles(input),
                "3" => service.KilogramsToPounds(input),
                "4" => service.CelsiusToKelvin(input),
                "5" => service.MilesToKilometers(input),
                _ => double.NaN
            };

            if (double.IsNaN(result))
                Console.WriteLine("Invalid option.");
            else
                Console.WriteLine($"Result: {result:F2}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine("Thanks for using CommonConversions!");
    }
}
