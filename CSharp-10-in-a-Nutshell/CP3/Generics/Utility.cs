namespace CSharp_10_in_a_Nutshell.CP3.Generics;

public class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    /*
    to use it in program.cs
    int x = 5, y = 10;
    Utility.Swap<int>(ref x, ref y);
    */
}