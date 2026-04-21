namespace CSharp_10_in_a_Nutshell.CP4.GenericDelegatesAndFuncAndAction;

public static class Test
{
    // use implemented delegates (func-action)
    public static void ExceuteTask(int a, int b, Func<int, int, int> mathOperation, Action<string> logger)
    {
        logger("Starting calculation...");
        int result = mathOperation(a, b);
        logger($"The result is: {result}");
    }
}