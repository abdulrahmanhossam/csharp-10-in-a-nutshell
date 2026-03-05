namespace CSharp_10_in_a_Nutshell.CP3.StaticConstructors;

public class Foo
{
    public static Foo Instance = new Foo();
    public static int x = 3;
    Foo() => Console.WriteLine(x);
}