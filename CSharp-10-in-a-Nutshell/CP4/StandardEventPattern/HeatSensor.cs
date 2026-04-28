namespace CSharp_10_in_a_Nutshell.CP4.StandardEventPattern;

public class HeatSensor
{
    private double _temperature;
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }

    public double Temperature
    {
        get => _temperature;
        set
        {
            if (_temperature != value)
            {
                _temperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
            }
        }
    }
}