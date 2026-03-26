namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public class CheckoutSystem
{
    // Take any class implement the interface (IPaymentProcessor)
    public void Checkout(IPaymentProcessor processor, decimal amount)
    {
        processor.Pay(amount); // Polymorphism!
    }
}