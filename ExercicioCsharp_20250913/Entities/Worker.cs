using ExercicioCsharp_20250913.Entities.Enums;

namespace ExercicioCsharp_20250913.Entities;

public class Worker
{
    public string name { get; set; }
    public WorkerLevel level { get; set; }
    public double baseSalary { get; set; }

    public Department department { get; set; }
    public List<HourContract> listContract = new List<HourContract>();
    
    public Worker()
    {
    }

    public Worker(string name, WorkerLevel level, double baseSalary, Department department)
    {
        this.name = name;
        this.level = level;
        this.baseSalary = baseSalary;
        this.department = department;
    }

    public void addContract(HourContract contract)
    {
        listContract.Add(contract);
    }

    public void removeContract(HourContract contract)
    {
        listContract.Remove(contract);
    }

    public double income(int year, int month)
    {
        double sum = 0;
        foreach (HourContract contract in listContract)
        {
            if (contract.date.Month.Equals(month) && contract.date.Year.Equals(year))
            {
                sum += contract.totalValue();
            }
        }
        return sum + baseSalary;
    }
    
}