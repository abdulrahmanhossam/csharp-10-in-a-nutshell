namespace CSharp_10_in_a_Nutshell.CP3.SealingFunctionsAndClasses;

public sealed class SecureCryptoPayment : PaymentGateway
{
    // if wn want to make a new class like (HackerPayment)
    //  and inhret to hack the payment to clr will make err and stopend us cuse (SecureCryptoPayment) (seald) 
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount}$ via AES-256 SECURE gateway.");
    }
}