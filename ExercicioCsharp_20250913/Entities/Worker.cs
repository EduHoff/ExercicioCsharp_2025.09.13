using ExercicioCsharp_20250913.Entities.Enums;

namespace ExercicioCsharp_20250913.Entities;

public class Worker
{
    public string name { get; set; }
    public WorkerLevel level { get; set; }
    public double baseSalary { get; set; }

    public Department department { get; set; }
    public List<HourContract> contract;
    
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
        this.contract.Add(contract);
    }

    public void removeContract(HourContract contract)
    {
        this.contract.Remove(contract);
    }

    public double income(int year, int month)
    {
        return 0;
    }
    
}