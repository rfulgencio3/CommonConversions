namespace CommonConversions.Application.Services;

public class ConversionService
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double KilometersToMiles(double km)
    {
        return km * 0.621371;
    }

    public double KilogramsToPounds(double kg)
    {
        return kg * 2.20462;
    }

    // Método Atividades Parte Um - CelsiusToKelvin
    public double CelsiusToKelvin(double celsius) => celsius + 273.15;

    // Método Atividades Parte Um - MilesToKilometers
    public double MilesToKilometers(double miles) => miles / 0.621371;
}
