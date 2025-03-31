using CommonConversions.Application.Services;

namespace CommonConversions.Application.UnitTests.Services;

public class ConversionServiceTests
{
    [Fact]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();
        double input = 0;

        // Act
        double result = service.CelsiusToFahrenheit(input);

        // Assert
        Assert.Equal(32, result);
    }

    [Fact]
    public void KilometersToMiles_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.KilometersToMiles(1);
        
        // Assert
        Assert.Equal(0.621371, result, 5); 
    }

    [Fact]
    public void CelsiusToKelvin_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.CelsiusToKelvin(0);

        // Assert
        Assert.Equal(273.15, result, 2);
    }

    [Fact]
    public void MilesToKilometers_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();

        // Act
        double result = service.MilesToKilometers(1);

        // Assert
        Assert.Equal(1.60934, result, 4);
    }
}
