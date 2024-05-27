public class Simple : GoalSet
{
    public Simple(string name, string description, int points, string boolean, string type) : base(name, description, points, "Simple")
    {
        Name = name;
        Description = description;
        Points = points;
        Boolean = boolean;
        Type = type;

    }
}