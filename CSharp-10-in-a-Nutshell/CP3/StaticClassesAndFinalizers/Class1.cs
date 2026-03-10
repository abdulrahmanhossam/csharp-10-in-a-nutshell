namespace CSharp_10_in_a_Nutshell.CP3.StaticClassesAndFinalizers;

public class Class1
{
    ~Class1() // Here just Trick
    {
    }

    // what really going under the hood

    // protected override void Finalize()
    // {

    //     base.Finalize(); 
    // }
}