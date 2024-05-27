public class Eternal : GoalSet
{

    public Eternal(string name, string description, int points, string type) : base(name, description, points, "Eternal")
    {
        Name = name;
        Description = description;
        Points = points;
        Type = type;
    }
}