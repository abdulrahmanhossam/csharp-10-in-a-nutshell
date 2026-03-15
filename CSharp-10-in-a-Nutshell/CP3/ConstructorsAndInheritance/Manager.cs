namespace CSharp_10_in_a_Nutshell.CP3.ConstructorsAndInheritance;

public class Manager : Employee
{
    public int TeamSize { get; } // Filed here take the Init Value 

    public Manager(string name, int teamSize)
        : base(name) // Ctor of base class Execute First
    {
        TeamSize = teamSize;
        Console.WriteLine($"Manager initialized. Team size: {TeamSize}");
    }
}