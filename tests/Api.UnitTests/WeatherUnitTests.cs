using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Api.UnitTests;

public class WeatherUnitTests
{
    [Fact]
    public async Task Weather_Forecast_Should_Not_Be_Empty()
    {
        // Arrange
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        //Act
        var response = await client.GetStringAsync("/weather-forecast");

        //Assert
        response?.Should().NotBeEmpty();

    }
}
