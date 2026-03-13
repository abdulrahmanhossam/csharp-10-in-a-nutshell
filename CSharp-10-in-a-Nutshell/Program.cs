using CSharp_10_in_a_Nutshell.CP3.Indexers;
using CSharp_10_in_a_Nutshell.CP3.InheritanceAndPolymorphism;
using CSharp_10_in_a_Nutshell.CP3.StaticConstructors;
using CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;

class Program
{
    static void Main(string[] args)
    {
        #region CP3

        #region Indexers

        #region Ex-1
        // Sentence s = new Sentence();
        // Console.WriteLine(s[3]);
        // s[3] = "kangaroo";
        // Console.WriteLine(s[3]);
        #endregion

        #region Ex-2
        // var validation = new ValidationResult();

        // validation["Email"] = "Email cannot be empty!";
        // validation["Password"] = "Password is too short!";

        // Console.WriteLine(validation["Email"]);
        // Console.WriteLine(validation["Age"]);
        #endregion
        #endregion

        #region Static-Constructors

        #region Ex-1
        //Console.WriteLine(Foo.x);
        #endregion

        #region Ex-2
        // // Reading config file from hard drive...
        // // AppConfig is ready!
        // AppConfig.PrintStatus();

        // // AppConfig is ready!
        // AppConfig.PrintStatus();
        #endregion

        #endregion

        #region InheritanceAndPolymorphism

        #region Ex-1
        // Stock msft = new Stock { Name = "MSFT", SharesOwned = 1000 };
        // Console.WriteLine(msft.Name);
        #endregion

        #region Ex-2
        // SavingsAccount mySavings = new SavingsAccount { AccountNumber = "SA-123", InterestRate = 0.05m };

        // mySavings.Deposit(1000);
        // PrintBalance(mySavings);
        #endregion

        #endregion

        #region VirtualFunctionMembers

        #region Ex-1
        // House mansion = new House { Name = "McMansion", Mortgage = 250000 };
        // CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers.Asset a = mansion; // (Upcast)

        // Console.WriteLine(mansion.Liability); // 250000
        // Console.WriteLine(a.Liability);       // 250000
        #endregion

        #region Ex-2
        // EmailValidator validator = new StringValidator(); // (Upcast)

        // bool isValid = validator.Validate("hello");
        // Console.WriteLine(isValid);
        #endregion

        #endregion

        #endregion
    }

    static void PrintBalance(BankAccount account)
    {
        Console.WriteLine($"Account {account.AccountNumber} has balance: {account.Balance}");
    }
}