namespace CSharp_10_in_a_Nutshell.CP3.GetTypeAndTypeofAndToString;

public abstract class Transaction
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public override string ToString()
    {
        return $"[{GetType().Name}] on {Date}: ${Amount}";
    }
}