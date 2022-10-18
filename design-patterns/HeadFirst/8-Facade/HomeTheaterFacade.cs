using System;
namespace design_patterns.HeadFirst.Facade
{
    public class HomeTheaterFacade
    {
        // this is a composition (all component of the subsystem we are going to use)
        Amplifier amp;
        Tuner tuner;
        StreamingPlayer player;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;

        // a facade is passed as a reference to each component in its constructor.
        // the correspondent instance variable is assigned
        public HomeTheaterFacade(Amplifier amp,
                     Tuner tuner,
                     StreamingPlayer player,
                     Projector projector,
                     Screen screen,
                     TheaterLights lights,
                     PopcornPopper popper)
        {

            this.amp = amp;
            this.tuner = tuner;
            this.player = player;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        // wrapping complexity here 
        public void watchMovie(String movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setStreamingPlayer(player);
            amp.setSurroundSound();
            amp.setVolume(5);
            player.on();
            player.play(movie);
        }


        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            player.stop();
            player.off();
        }

        public void listenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            tuner.on();
            tuner.setFrequency(frequency);
            amp.on();
            amp.setVolume(5);
            amp.setTuner(tuner);
        }

        public void endRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            tuner.off();
            amp.off();
        }
    }

    public class PopcornPopper
    {
        internal void off()
        {
            Console.WriteLine("Off");
        }

        internal void on()
        {
            Console.WriteLine("On");
        }

        internal void pop()
        {
            Console.WriteLine("Pop");
        }
    }

    public class TheaterLights
    {
        internal void dim(int v)
        {
            Console.WriteLine("dim");
        }

        internal void on()
        {
            Console.WriteLine("on");
        }
    }

    public class Projector
    {
        internal void off()
        {
            Console.WriteLine("Off");
        }

        internal void on()
        {
            Console.WriteLine("On");
        }

        internal void wideScreenMode()
        {
            Console.WriteLine("wide screen mode");
        }
    }

    public class CdPlayer
    {
        String description;
        int currentTrack;
        Amplifier amplifier;
        String title;

        public CdPlayer(String description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void eject()
        {
            title = null;
            Console.WriteLine(description + " eject");
        }

        public void play(String title)
        {
            this.title = title;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + title + "\"");
        }

        public void play(int track)
        {
            if (title == null)
            {
                Console.WriteLine(description + " can't play track " + currentTrack +
                        ", no cd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack);
            }
        }

        public void stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped");
        }

        public void pause()
        {
            Console.WriteLine(description + " paused \"" + title + "\"");
        }

        public String toString()
        {
            return description;
        }
    }

    public class StreamingPlayer
    {
        internal void off()
        {
            Console.WriteLine("Off");
        }

        internal void on()
        {
            Console.WriteLine("on");
        }

        internal void play(string movie)
        {
            Console.WriteLine("play");
        }

        internal void stop()
        {
            Console.WriteLine("stop");
        }
    }

    public class Amplifier
    {
        String description;
        Tuner tuner;
        StreamingPlayer player;

        public Amplifier(String description)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void setStereoSound()
        {
            Console.WriteLine(description + " stereo mode on");
        }

        public void setSurroundSound()
        {
            Console.WriteLine(description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void setVolume(int level)
        {
            Console.WriteLine(description + " setting volume to " + level);
        }

        public void setTuner(Tuner tuner)
        {
            Console.WriteLine(description + " setting tuner to " + tuner);
            this.tuner = tuner;
        }

        public void setStreamingPlayer(StreamingPlayer player)
        {
            Console.WriteLine(description + " setting Streaming player to " + player);
            this.player = player;
        }

        public String toString()
        {
            return description;
        }
    }

    public class Tuner
    {
        String description;
        Amplifier amplifier;
        double frequency;

        public Tuner(String description, Amplifier amplifier)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void setFrequency(double frequency)
        {
            Console.WriteLine(description + " setting frequency to " + frequency);
            this.frequency = frequency;
        }

        public void setAm()
        {
            Console.WriteLine(description + " setting AM mode");
        }

        public void setFm()
        {
            Console.WriteLine(description + " setting FM mode");
        }

        public String toString()
        {
            return description;
        }
    }

    public class Screen
    {
        String description;

        public Screen(String description)
        {
            this.description = description;
        }

        public void up()
        {
            Console.WriteLine(description + " going up");
        }

        public void down()
        {
            Console.WriteLine(description + " going down");
        }


        public String toString()
        {
            return description;
        }
    }
}

