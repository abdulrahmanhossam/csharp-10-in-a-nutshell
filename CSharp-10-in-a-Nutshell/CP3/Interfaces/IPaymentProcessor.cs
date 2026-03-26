namespace CSharp_10_in_a_Nutshell.CP3.Interfaces;

public interface IPaymentProcessor
{
    bool Pay(decimal amount);
}