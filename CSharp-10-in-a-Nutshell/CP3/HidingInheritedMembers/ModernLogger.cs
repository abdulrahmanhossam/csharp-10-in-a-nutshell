namespace CSharp_10_in_a_Nutshell.CP3.HidingInheritedMembers;

public class ModernLogger : OldLogger
{
    // if we use (override) here can use (OldLogger log = new ModernLogger())
    // and use the method off ModernLogger
    // if we use (new) can not use (OldLogger log = new ModernLogger())
    // if use the  LogErr method we will use OldLogger
    public new void LogErr(string msg)
    {
        Console.WriteLine($"[MODERN LOG] Saved to Cloud Database: {msg}");
    }
}