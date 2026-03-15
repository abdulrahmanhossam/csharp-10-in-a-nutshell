namespace CSharp_10_in_a_Nutshell.CP3.ConstructorsAndInheritance;

public class Employee
{
    public string Name { get; }

    // Ctor take name as param 
    // Ctor Of Base Here Execute First
    public Employee(string name)
    {
        Name = name;
        Console.WriteLine($"Employee base initialized for: {Name}");
    }
}