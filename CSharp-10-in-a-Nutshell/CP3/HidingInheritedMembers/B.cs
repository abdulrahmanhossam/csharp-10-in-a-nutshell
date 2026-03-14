namespace CSharp_10_in_a_Nutshell.CP3.HidingInheritedMembers;

public class B : A
{
    // use (new) word to make warning disapper
    public new int Counter = 2; // we get warning becuase hiding base class (Counter) (A)
}