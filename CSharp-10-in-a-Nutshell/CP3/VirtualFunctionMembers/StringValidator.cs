namespace CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;

// Base Class
public class StringValidator
{
    // virtual method just make sure the input not null or empty
    public virtual bool Validate(string input)
    {
        Console.WriteLine("Running Base Validator...");
        return !string.IsNullOrEmpty(input);
    }
}


