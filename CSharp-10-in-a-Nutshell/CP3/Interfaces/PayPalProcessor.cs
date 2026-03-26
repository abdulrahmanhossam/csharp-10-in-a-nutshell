namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public class PayPalProcessor : IPaymentProcessor
{
    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Redirecting to PayPal... Paid ${amount}");
        return true;
    }
}