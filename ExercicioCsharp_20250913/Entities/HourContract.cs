namespace ExercicioCsharp_20250913.Entities;

public class HourContract
{
    public DateTime date { get; set; }
    public double valuePerHour { get; set; }
    public int hours { get; set; }

    public HourContract()
    {
    }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        this.date = date;
        this.valuePerHour = valuePerHour;
        this.hours = hours;
    }

    public double totalValue()
    {
        return hours * valuePerHour;
    }
}