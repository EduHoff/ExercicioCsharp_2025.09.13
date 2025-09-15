using System.Globalization;
using ExercicioCsharp_20250913.Entities;
using ExercicioCsharp_20250913.Entities.Enums;

namespace ExercicioCsharp_20250913.Application;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter department's name: ");
        Department department = new Department(Console.ReadLine());
        
        Console.WriteLine("Enter Worker data:");
        
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine());

        Worker obj = new Worker(name, level, baseSalary, department);
        
        Console.Write("How many contract to this worker? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter #" + i+1 + " contract data:");
            
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date, valuePerHour, hours);
            obj.addContract(contract);
        }
        
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        DateTime incomeDate = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Name: " + obj.name);
        Console.WriteLine("Department: " + obj.department);
        Console.WriteLine("Income for " + incomeDate.ToString("MM/yyyy") + ": " + obj.income(incomeDate.Year, incomeDate.Month).ToString("F2", CultureInfo.InvariantCulture));
        
        


    }
}