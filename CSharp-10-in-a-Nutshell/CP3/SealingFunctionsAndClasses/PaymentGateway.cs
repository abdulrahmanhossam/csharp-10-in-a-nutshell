namespace CSharp_10_in_a_Nutshell.CP3.SealingFunctionsAndClasses;

public class PaymentGateway
{
    public virtual void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount}$ via standerd gateway");
    }
}