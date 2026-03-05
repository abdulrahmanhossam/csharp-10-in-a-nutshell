namespace CSharp_10_in_a_Nutshell.CP3.StaticConstructors;

public class AppConfig
{
    public static readonly string ConnectionString;

    static AppConfig()
    {
        Console.WriteLine("Reading config file from hard drive...");

        ConnectionString = "Server=myServer;Database=myDB";
    }

    public static void PrintStatus()
    {
        Console.WriteLine("AppConfig is ready!");
    }
}