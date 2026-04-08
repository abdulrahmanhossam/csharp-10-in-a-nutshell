namespace CSharp_10_in_a_Nutshell;

public delegate void LogAction(string message);
public class SystemManager
{
    public void ProcessData(LogAction logMethod)
    {
        Console.WriteLine("Processing complex data...");
        logMethod("An error ouccurred during processing.");
    }
}