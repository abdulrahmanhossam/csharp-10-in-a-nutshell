namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public class Countdown : IEnumerator
{
    int count = 11;

    // must implement this method and prop
    public bool MoveNext() => count-- > 0;

    public object Current => count;
}