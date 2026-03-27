namespace CSharp_10_in_a_Nutshell.CP3.ExplicitInterfaceImplementation;

public class ReportDocument : IDatabaseStorable, IPrintable
{
    // Explicit implementation of the database interface
    void IDatabaseStorable.Save()
    {
        Console.WriteLine("Saving report securely to SQL Database...");
    }

    void IPrintable.Save()
    {
        Console.WriteLine("Exporting report to PDF file...");
    }
}