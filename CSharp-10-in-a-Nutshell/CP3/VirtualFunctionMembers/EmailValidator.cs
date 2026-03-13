namespace CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;

// Derived Class
public class EmailValidator : StringValidator
{
    // add more rules to check validate of email
    public override bool Validate(string input)
    {
        Console.WriteLine("Running Email Validator...");

        // later we will talk about (base) word
        return !string.IsNullOrEmpty(input) && input.Contains("@");
    }
}