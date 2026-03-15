namespace CSharp_10_in_a_Nutshell.CP3.ConstructorsAndInheritance;

public class Subclass2 : BaseClass2
{
    // Invoke Explicitly (Ctor) and pass param to Base Class using (base) keyword
    public Subclass2(int x)
        : base(x) { }
}