namespace CSharp_10_in_a_Nutshell.CP3.StaticClassesAndFinalizers;

public class TempFileHandler
{
    private string _filePath;

    public TempFileHandler(string fileName)
    {
        _filePath = $"C:\\Temp\\{fileName}";

        Console.WriteLine($"File created at: {_filePath}");
    }

    ~TempFileHandler()
    {
        Console.WriteLine($"Emergency cleanup! Deleting file: {_filePath}");
    }
}