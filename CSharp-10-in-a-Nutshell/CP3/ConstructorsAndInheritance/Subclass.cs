namespace CSharp_10_in_a_Nutshell.CP3.ConstructorsAndInheritance;

public class Subclass : BaseClass
{
    public Subclass()
    {
        Console.WriteLine(X);

        // Invoke Implicitly (Ctor)
        // Under the hood 
        // public Subclass() : base() { Console.WriteLine (X); }
    }
}