namespace CSharp_10_in_a_Nutshell.CP3.AbstractClassesAndAbstractMembers;

public class EmailValidator : BaseValidator
{
    public EmailValidator()
        : base("Email")
    {

    }

    public override string GetErrorMessage() => $"{FieldName} is not a valid email.";

    public override bool IsValid(string input)
    {
        return input != null && input.Contains("@");
    }
}