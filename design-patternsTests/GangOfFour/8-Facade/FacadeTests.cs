using System;
using design_patterns.HeadFirst.Facade;
using Xunit;

namespace design_patternsTests.HeadFirst.Facade
{
    public class FacadeTests
    {
        [Fact]
        public void WorkingWithFacade()
        {
            var amp = new Amplifier("Amplifier");
            var tuner = new Tuner("Tuner", amp);
            var streamPlayer = new StreamingPlayer();
            var projector = new Projector();
            var screen = new Screen("Desc");
            var theaterLights = new TheaterLights();
            var popCorn = new PopcornPopper();

            var homeTheater = new HomeTheaterFacade(amp, tuner, streamPlayer, projector, screen, theaterLights, popCorn);

            homeTheater.watchMovie("Movie");
            homeTheater.endMovie();
        }
    }
}

