namespace CSharp_10_in_a_Nutshell.CP3.InheritanceAndPolymorphism;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal amount) => Balance += amount;
}