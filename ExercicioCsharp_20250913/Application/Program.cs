using ExercicioCsharp_20250913.Entities;
using ExercicioCsharp_20250913.Entities.Enums;

namespace ExercicioCsharp_20250913.Application;

class Program
{
    static void Main(string[] args)
    {
        Worker wk = new Worker("Eduardo", WorkerLevel.SENIOR, 2000, new Department("TI"));
        
        Console.WriteLine(wk.name);
        Console.WriteLine(wk.level);
        Console.WriteLine(wk.baseSalary);
        Console.WriteLine(wk.department);
    }
}