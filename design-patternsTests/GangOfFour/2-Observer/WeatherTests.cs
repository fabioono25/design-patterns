
using design_patterns.HeadFirst.Observer;
using Xunit;

namespace design_patternsTests.HeadFirst.Observer
{
    public class WeatherTests
    {
        [Fact]
        public void ShouldReturnTheSameInstance(){

            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 12, 23.2f);
            weatherData.setMeasurements(70, 20, 40.5f);
            weatherData.setMeasurements(60, 49, 89f);
        }        
    }
}