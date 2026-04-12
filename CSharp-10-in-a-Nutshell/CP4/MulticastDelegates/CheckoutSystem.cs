namespace CSharp_10_in_a_Nutshell.CP4.MulticastDelegates;

public delegate void OrderCompletedHandler(string orderId);
public class CheckoutSystem
{
    public OrderCompletedHandler? OnOrderComplete;

    public void ProcessPaymet(string orderId)
    {
        Console.WriteLine($"Payment processed for Order: {orderId}");

        if (OnOrderComplete != null)
        {
            OnOrderComplete(orderId);
        }
    }
}