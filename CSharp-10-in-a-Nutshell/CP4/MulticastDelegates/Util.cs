namespace CSharp_10_in_a_Nutshell.CP4.MulticastDelegates;

public delegate void ProgressReporter(int percentComplete);

public class Util
{
    public static void HardWork(ProgressReporter progress)
    {
        for (int i = 0; i < 10; i++)
        {
            progress(i * 10);
            Thread.Sleep(100);
        }
    }
}