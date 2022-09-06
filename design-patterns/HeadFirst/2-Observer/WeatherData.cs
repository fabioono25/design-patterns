using System;
using System.Collections.Generic;

namespace design_patterns.HeadFirst.Observer
{
    public class WeatherData : Subject
    {
        private List<Observer> _observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            _observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            _observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }

    public interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers(); // when Subject's state has changed
    }

    public interface Observer
    {
        // TODO: if my display doesn't use some of these parameters?!?
        public void update(float temp, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        public void display();
    }

    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        // we don't use need pressure here
        public void update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {_temperature} Celcius and {_humidity} humidity.");
        }
    }
}

