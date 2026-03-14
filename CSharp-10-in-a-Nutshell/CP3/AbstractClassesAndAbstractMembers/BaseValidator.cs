namespace CSharp_10_in_a_Nutshell.CP3.AbstractClassesAndAbstractMembers;

public abstract class BaseValidator
{
    public string? FieldName { get; set; }
    public BaseValidator(string fieldName)
    {
        fieldName = FieldName!;
    }

    public abstract bool IsValid(string input);
    public abstract string GetErrorMessage();
}