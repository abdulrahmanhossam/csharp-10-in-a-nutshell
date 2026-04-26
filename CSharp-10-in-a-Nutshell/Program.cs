using CSharp_10_in_a_Nutshell.CP3.HidingInheritedMembers;
using CSharp_10_in_a_Nutshell.CP3.Indexers;
using CSharp_10_in_a_Nutshell.CP3.InheritanceAndPolymorphism;
using CSharp_10_in_a_Nutshell.CP3.StaticConstructors;
using CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;
using CSharp_10_in_a_Nutshell.CP3.GetTypeAndTypeofAndToString;
using CSharp_10_in_a_Nutshell.CP3.Interfaces;
using CSharp_10_in_a_Nutshell.CP3.ExplicitInterfaceImplementation;
using CSharp_10_in_a_Nutshell.CP3.GenericConstraints.BackendCase;
using CSharp_10_in_a_Nutshell.CP4.Delegate;
using CSharp_10_in_a_Nutshell.CP4.MulticastDelegates;
using CheckoutSystem = CSharp_10_in_a_Nutshell.CP4.MulticastDelegates.CheckoutSystem;
using CSharp_10_in_a_Nutshell.CP4.GenericDelegatesAndFuncAndAction;
using CSharp_10_in_a_Nutshell.CP4.Events.YouTubeChannel;

class Program
{
    #region Delagate

    #region Ex-1
    delegate int Transformer(int x);

    static int Square(int x)
    {
        return x * x;
    }
    #endregion

    #region Ex-2
    static void LogToConsole(string msg)
        => Console.WriteLine($"[CONSOLE]: {msg}");

    static void LogToFile(string msg)
        => File.WriteAllText("log.txt", msg);
    #endregion
    #endregion

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

        #region HidingInheritedMembers

        #region Ex-1
        // B b = new B();
        // A a = b;

        // Console.WriteLine(b.Counter);
        // Console.WriteLine(a.Counter);
        #endregion

        #region Ex-2
        // ModernLogger myLogger = new ModernLogger();
        // myLogger.LogErr("System Crash"); // MODERN LOG

        // // OldLogger (Upcast)
        // // if we use (override) here can use (OldLogger log = new ModernLogger())
        // // and use the method off ModernLogger
        // // if we use (new) can not use (OldLogger log = new ModernLogger())
        // // if use the  LogErr method we will use OldLogger
        // OldLogger legacyRef = myLogger;
        // legacyRef.LogErr("System Crash");
        #endregion

        #endregion

        #region BoxingAndUnboxing

        #region Ex-1
        // int x = 9;
        // object obj = x; // here we make boxing form (val) to (ref)
        // int y = (int)obj; // here we make unboxing form (ref) to (val)
        #endregion

        #region Ex-2
        // int i = 3;
        // // boxing just take a copy from i = 3
        // object boxed = i; // now whe have here (3) after boxing
        // i = 5;   // if we change the (i) after boxing the (boxed varible) will not be change
        // Console.WriteLine(boxed); // here will print (3) cuse its the val of (boxed)
        #endregion

        #endregion

        #region GetTypeAndTypeofAndToString

        #region Ex-1
        // Point p = new Point();
        // Console.WriteLine(p.GetType().Name);
        // Console.WriteLine(typeof(Point).Name);

        // Console.WriteLine(p.GetType() == typeof(Point));
        #endregion

        #region Ex-2
        // Panda p = new Panda { Name = "Petey" };
        // Console.WriteLine(p);
        #endregion

        #region Ex-3
        // Transaction t1 = new Deposit { Amount = 1500 };
        // Transaction t2 = new Withdrawal { Amount = 200 };

        // Console.WriteLine(t1);
        // Console.WriteLine(t2);
        #endregion

        #endregion

        #region Structs

        #region Ex-1
        // var p1 = new CSharp_10_in_a_Nutshell.CP3.Structs.Point();
        // p1.X = 7;

        // var p2 = p1;
        // p2.X = 9;

        // Console.WriteLine(p1.X);
        #endregion

        #endregion

        #region Interfaces

        #region Ex-1
        // var checkout = new CheckoutSystem();

        // // Customer choose visa
        // checkout.Checkout(new VisaProcessor(), 100);

        // // Customer choose paypal
        // checkout.Checkout(new PayPalProcessor(), 50);
        #endregion

        #endregion

        #region ExplicitInterfaceImplementation

        #region Ex-1

        // ReportDocument myReport = new ReportDocument();

        // // myReport.Save(); // must make cast to do this

        // IDatabaseStorable dbDoc = myReport;
        // dbDoc.Save(); // SQL

        // IPrintable printDoc = myReport;
        // printDoc.Save(); // PDF
        #endregion

        #endregion

        #region GenericConstraints

        #region Ex-1
        // var userRepo = new GenericRepository<User>();
        // User u = userRepo.CreateNewRecord();
        // userRepo.SaveToDatabase(u);
        #endregion

        #endregion

        #endregion

        #region CP4

        #region Delagate-Exce

        #region Ex-1
        // Transformer t = Square;
        // // This will call (delagate) and he will (Square) method
        // int result = t(3);
        // Console.WriteLine(result);
        #endregion

        #region Ex-2
        // var manager = new SystemManager();

        // manager.ProcessData(LogToConsole);
        // manager.ProcessData(LogToConsole);
        #endregion

        #endregion

        #region MulticastDelegates-Exce

        #region  Ex-1
        // ProgressReporter progress = WriteProgressToConsole;
        // progress += WriteProgressToFile;

        // // we here just send the deegate thats
        // // contains some of pointers to metheods we are added
        // // he will sort exce by adding 
        // Util.HardWork(progress);
        #endregion

        #region  Ex-2
        // CheckoutSystem checkout = new CheckoutSystem();

        // checkout.OnOrderComplete += SendEmail;
        // checkout.OnOrderComplete += SendSMS;
        // checkout.OnOrderComplete += LogToDatabase;

        // checkout.ProcessPaymet("ORD-12345");
        #endregion

        #endregion

        #region GenericDelegatesAndFuncAndAction-Exce

        #region  Ex-1
        // Test.ExceuteTask(10, 5, Add, PrintToScreen);
        #endregion

        #endregion

        #region Events

        #region  Ex-1

        // YouTubeChannel channel = new YouTubeChannel();
        // Subscriber sub1 = new Subscriber();
        // Subscriber sub2 = new Subscriber();

        // -> notify subscriberies that added to event
        // channel.OnVideoUploaded += sub1.WatchVideo;
        // channel.OnVideoUploaded += sub2.WatchVideo;

        // ->  not vaild see errors 
        // channel.OnVideoUploaded = sub1.WatchVideo;
        // channel.OnVideoUploaded = null; 
        // channel.OnVideoUploaded("Fake Video!");

        #endregion

        #endregion

        #endregion
    }

    #region GenericDelegatesAndFuncAndAction

    #region  Ex-1
    static int Add(int x, int y) => x + y;
    static void PrintToScreen(string msg) => Console.WriteLine($"[LOG]: {msg}");
    #endregion

    #endregion

    #region MulticastDelegates

    #region Ex-1
    static void WriteProgressToConsole(int p)
        => Console.WriteLine(p);
    static void WriteProgressToFile(int p)
        => File.WriteAllText("progress.txt", p.ToString());
    #endregion

    #region Ex-2

    static void SendEmail(string id)
         => Console.WriteLine($"-> Email sent for {id}");
    static void SendSMS(string id)
        => Console.WriteLine($"-> SMS sent for {id}");
    static void LogToDatabase(string id)
        => Console.WriteLine($"-> Saved to DB: {id}");
    #endregion

    #endregion

    static void PrintBalance(BankAccount account)
    {
        Console.WriteLine($"Account {account.AccountNumber} has balance: {account.Balance}");
    }
}