namespace CSharp_10_in_a_Nutshell.CP3.VirtualFunctionMembers;

public class House : Asset
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;
}