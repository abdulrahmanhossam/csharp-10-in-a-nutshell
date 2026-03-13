namespace CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;

public class Asset
{
    public string Name;
    
    // use virtual to can be override on this member
    public virtual decimal Liability => 0;
}