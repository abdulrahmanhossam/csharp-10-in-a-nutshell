namespace CSharp_10_in_a_Nutshell.CP3.PartialTypesAndMethods;

// User.Designer.cs
public partial class User
{
    public string Email { get; set; }
    partial void OnEmailChanging(string newEmail);

    public void UpdateEmail(string newEmail)
    {
        OnEmailChanging(newEmail);
        Email = newEmail;
    }
}

// User.Custom.cs
public partial class User
{
    partial void OnEmailChanging(string newEmail)
    {
        if (!newEmail.Contains("@"))
        {
            throw new Exception("Invalid Email Format!");
        }
    }
}