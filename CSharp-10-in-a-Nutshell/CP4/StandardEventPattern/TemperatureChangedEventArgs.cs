namespace CSharp_10_in_a_Nutshell.CP4.StandardEventPattern;

public class TemperatureChangedEventArgs : EventArgs
{
    private readonly double CurrentTemp;
    public TemperatureChangedEventArgs(double temp)
    {
        CurrentTemp = temp;
    }
}