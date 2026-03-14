namespace CSharp_10_in_a_Nutshell.CP3.HidingInheritedMembers;

public class OldLogger
{
    public void LogErr(string msg)
    {
        Console.WriteLine($"[OLD LOG] Saved to Text File: {msg}");
    }
}