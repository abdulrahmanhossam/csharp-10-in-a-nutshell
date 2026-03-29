namespace CSharp_10_in_a_Nutshell.CP3.NestedTypes;

public class TopLevel
{
    /*
    1- defualt access mod for nested class is (private)
    2- nested can see evey the public or private at outer class
    3- if we make nested class (public) we can use it in (program.cs) but must use outer like:
    TopLevel.Nested obj = new TopLevel.Nested();
    */
    static int x;

    // Nested class
    class Nested
    {
        static void Foo() { Console.WriteLine(TopLevel.x); }
    }
}