namespace CSharp_10_in_a_Nutshell.CP3.Structs;

public class WeatherSystem
{
    // This array will allocate a single contiguous block in memory, very light and fast
    RainParticle[] rainDrops = new RainParticle[100000];
}