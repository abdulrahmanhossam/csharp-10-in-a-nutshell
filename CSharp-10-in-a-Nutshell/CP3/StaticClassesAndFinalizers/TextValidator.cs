namespace CSharp_10_in_a_Nutshell.CP3.StaticClassesAndFinalizers;

public static class TextValidator
{
    public static bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}

