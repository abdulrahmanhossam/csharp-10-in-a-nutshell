namespace CSharp_10_in_a_Nutshell.CP3.AbstractClassesAndAbstractMembers;

public class Stock : Asset
{
    public long SharesOwned;
    public decimal CurrentPrice;

    // must override abstract member 
    public override decimal NetValue => CurrentPrice * SharesOwned;
}