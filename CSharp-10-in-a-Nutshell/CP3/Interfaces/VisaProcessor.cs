namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public class VisaProcessor : IPaymentProcessor
{
    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Connecting to Visa... Paid ${amount}");
        return true;
    }
}