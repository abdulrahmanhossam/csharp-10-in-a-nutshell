namespace CSharp_10_in_a_Nutshell.CP3.Generics.BackendCase;

public class Result<T>
{
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public T Data { get; set; }
}