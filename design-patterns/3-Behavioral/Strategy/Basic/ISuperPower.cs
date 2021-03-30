namespace design_patterns.Behavioral.Strategy.Basic
{
    // strategy
    public interface ISuperPower
    {
        string ExercisePower();
    }

    // concrete strategies
    public class RegularPerson : ISuperPower
    {
        public string ExercisePower() => "Ask for help!";
    }

    public class Fly : ISuperPower
    {
        public string ExercisePower() => "I am flying!";
    }

    public class Swim : ISuperPower
    {
        public string ExercisePower() => "I can swim!";
    }    
}