namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
}