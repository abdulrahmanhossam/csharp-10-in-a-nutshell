namespace CSharp_10_in_a_Nutshell.CP3.AccessModifiers;

public class BankAccount
{
    // private: The balance is very confidential! No one from the outside ever modifies it.
    private decimal _balance;

    // protected: The account number is available for this class, and for the types of accounts that will inherit from it only
    protected string AccountNumber;

    public BankAccount(string accNum)
    {
        AccountNumber = accNum;
        _balance = 0;
    }

    // public: Customers (from anywhere) are allowed to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            AuditTransaction("Deposit", amount); // use internal method
        }
    }

    // internal: This function records the transactions. It is allowed to be called from any class within the 'Bank System' only.
    internal void AuditTransaction(string type, decimal amount)
    {
        Console.WriteLine($"[AUDIT] {type} of ${amount} on Acc: {AccountNumber}");
    }
}