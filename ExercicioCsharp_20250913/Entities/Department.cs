namespace ExercicioCsharp_20250913.Entities;

public class Department
{
    public string name { get; set; }

    public Department()
    {
    }

    public Department(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}