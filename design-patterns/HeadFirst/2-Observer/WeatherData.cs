using System;
using System.Collections.Generic;

namespace design_patterns.HeadFirst.Observer
{
    // Observable
    public class WeatherData : Subject
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData() : base()
        {
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

        internal float getTemperature()
        {
            return this.temperature;
        }

        internal float getHumidity()
        {
            return this.humidity;
        }

        internal float getPressure()
        {
            return this.pressure;
        }
    }

    // Observable
    public abstract class Subject
    {
        private List<Observer> _observers;

        public Subject()
        {
          _observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
          _observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
          _observers.Remove(o);
        }

        public void notifyObservers()
        {
          foreach (var observer in _observers)
          {
            observer.update();
          }
        }
    }

    public interface Observer
    {
        // TODO: if my display doesn't use some of these parameters?!?
        //public void update(float temp, float humidity, float pressure);
        public void update();
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
        public void update()
        {
            // now the Observer can pull needed data from Subject
            _temperature = _weatherData.getTemperature();
            _humidity = _weatherData.getHumidity();
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {_temperature} Celcius and {_humidity} humidity.");
        }
    }
}

